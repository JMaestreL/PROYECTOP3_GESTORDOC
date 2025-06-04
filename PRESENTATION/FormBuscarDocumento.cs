using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace PRESENTATION
{
    public partial class FormBuscarDocumento : UserControl
    {
        public FormBuscarDocumento()
        {
            InitializeComponent();
            CargarTiposDocumento();
            CargarResultados(); 
        }

        private void CargarTiposDocumento()
        {
            var tipos = TipoDocumentoBLL.ObtenerTipos();
            comboTipoFiltro.DataSource = tipos;
            comboTipoFiltro.DisplayMember = "Nombre";
            comboTipoFiltro.ValueMember = "Id";
            comboTipoFiltro.SelectedIndex = -1; 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloFiltro.Text.Trim();
            string autor = txtAutorFiltro.Text.Trim();
            int? idTipo = comboTipoFiltro.SelectedIndex == -1 ? (int?)null : (int)comboTipoFiltro.SelectedValue;

            List<Documento> resultados = DocumentoBLL.BuscarDocumentos(titulo, autor, idTipo);
            dgvResultados.DataSource = resultados;
        }

        private void CargarResultados()
        {
            List<Documento> documentos = DocumentoBLL.ObtenerTodos();
            dgvResultados.DataSource = documentos;
        }

        private void dgvResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Documento doc = (Documento)dgvResultados.Rows[e.RowIndex].DataBoundItem;
                if (System.IO.File.Exists(doc.RutaArchivo))
                {
                    System.Diagnostics.Process.Start(doc.RutaArchivo);
                }
                else
                {
                    MessageBox.Show("No se encontró el archivo en la ruta guardada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
