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
    public partial class FormUsuario : UserControl
    {
        private string usuarioLogueado; 

        public FormUsuario(string nombreUsuario)
        {
            InitializeComponent();
            usuarioLogueado = nombreUsuario;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            try
            {
                Usuario user = UsuarioBLL.ObtenerPorNombreUsuario(usuarioLogueado);
                if (user != null)
                {
                    txtNombre.Text = user.Nombre;
                    txtCorreo.Text = user.Correo;
                    txtUsuario.Text = user.NombreUsuario;

                   
                    txtUsuario.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo cargar los datos del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario
                {
                    NombreUsuario = usuarioLogueado,
                    Nombre = txtNombre.Text.Trim(),
                    Correo = txtCorreo.Text.Trim()
                };

                bool resultado = UsuarioBLL.ActualizarUsuario(user);
                if (resultado)
                {
                    MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos: " + ex.Message);
            }
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
