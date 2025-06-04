using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTATION
{
    public partial class FormMenuPrincipal : Form
    {
        private string nombreUsuario;
        private string usuarioActual;


        public FormMenuPrincipal(string usuario)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            usuarioActual = usuario;
            nombreUsuario = usuario;
            lblBienvenida.Text = $"Bienvenido, {usuario}";
        }

        private void MostrarMiCuenta(string usuario)
        {
            panelContenido.Controls.Clear();
            var uc = new FormUsuario(usuario);
            uc.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(uc);
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            MostrarMiCuenta(usuarioActual);
        }


        private void AbrirControlEnPanel(Control control)
        {
            panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(control);
        }

        private void btnSubirDocumento_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new FormSubirDocumento()); 
        }

        private void btnBuscarDocumento_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new FormBuscarDocumento()); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
