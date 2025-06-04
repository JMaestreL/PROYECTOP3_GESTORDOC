using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;
using Tesseract;

namespace PRESENTATION
{
    public partial class FormSubirDocumento : UserControl
    {
        private string rutaImagen = "";
        private string textoExtraido = "";

        public FormSubirDocumento()
        {
            InitializeComponent();
            CargarTiposDocumento();
        }

        private void CargarTiposDocumento()
        {
            var tipos = TipoDocumentoBLL.ObtenerTipos();
            comboTipo.DataSource = tipos;
            comboTipo.DisplayMember = "Nombre";
            comboTipo.ValueMember = "Id";
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = dialog.FileName;
                pictureBox1.Image = Image.FromFile(rutaImagen);
            }
        }

        private void btnExtraerTexto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaImagen))
            {
                MessageBox.Show("Primero selecciona una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", "spa", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(rutaImagen))
                    {
                        using (var page = engine.Process(img))
                        {
                            textoExtraido = page.GetText();
                            txtContenido.Text = textoExtraido;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aplicar OCR: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || comboTipo.SelectedIndex == -1 || string.IsNullOrEmpty(textoExtraido))
            {
                MessageBox.Show("Por favor, completa los campos obligatorios y aplica OCR.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombreArchivo = Guid.NewGuid().ToString() + ".txt";
            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DocumentosGuardados");

            if (!Directory.Exists(carpetaDestino))
                Directory.CreateDirectory(carpetaDestino);

            string rutaArchivo = Path.Combine(carpetaDestino, nombreArchivo);
            File.WriteAllText(rutaArchivo, textoExtraido);

            Documento doc = new Documento
            {
                Titulo = txtTitulo.Text.Trim(),
                Tipo = new TipoDocumento { Id = (int)comboTipo.SelectedValue },
                Autor = txtAutor.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                FechaCreacion = DateTime.Now,
                RutaArchivo = rutaArchivo
            };

            bool resultado = DocumentoBLL.Guardar(doc);

            if (resultado)
            {
                MessageBox.Show("Documento guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Error al guardar el documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            rutaImagen = "";
            textoExtraido = "";
            pictureBox1.Image = null;
            txtTitulo.Clear();
            txtAutor.Clear();
            txtDescripcion.Clear();
            txtContenido.Clear();
            comboTipo.SelectedIndex = -1;
        }

        private void FormSubirDocumento_Load(object sender, EventArgs e)
        {

        }
    }
}
