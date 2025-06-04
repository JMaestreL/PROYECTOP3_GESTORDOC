using System.Windows.Forms;

namespace PRESENTATION
{
    partial class FormMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelLateral;
        private Button btnSubirDocumento;
        private Button btnBuscarDocumento;
        private Button btnSalir;
        private Panel panelContenido;
        private Label lblBienvenida;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnCuenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarDocumento = new System.Windows.Forms.Button();
            this.btnSubirDocumento = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLateral.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelLateral.Controls.Add(this.btnCuenta);
            this.panelLateral.Controls.Add(this.btnSalir);
            this.panelLateral.Controls.Add(this.btnBuscarDocumento);
            this.panelLateral.Controls.Add(this.btnSubirDocumento);
            this.panelLateral.Controls.Add(this.lblBienvenida);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 500);
            this.panelLateral.TabIndex = 0;
            // 
            // btnCuenta
            // 
            this.btnCuenta.Location = new System.Drawing.Point(20, 198);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(160, 37);
            this.btnCuenta.TabIndex = 5;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(20, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarDocumento
            // 
            this.btnBuscarDocumento.Location = new System.Drawing.Point(20, 140);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Size = new System.Drawing.Size(160, 40);
            this.btnBuscarDocumento.TabIndex = 2;
            this.btnBuscarDocumento.Text = "Buscar Documento";
            this.btnBuscarDocumento.UseVisualStyleBackColor = true;
            this.btnBuscarDocumento.Click += new System.EventHandler(this.btnBuscarDocumento_Click);
            // 
            // btnSubirDocumento
            // 
            this.btnSubirDocumento.Location = new System.Drawing.Point(20, 80);
            this.btnSubirDocumento.Name = "btnSubirDocumento";
            this.btnSubirDocumento.Size = new System.Drawing.Size(160, 40);
            this.btnSubirDocumento.TabIndex = 1;
            this.btnSubirDocumento.Text = "Subir Documento";
            this.btnSubirDocumento.UseVisualStyleBackColor = true;
            this.btnSubirDocumento.Click += new System.EventHandler(this.btnSubirDocumento_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(10, 20);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(180, 40);
            this.lblBienvenida.TabIndex = 4;
            this.lblBienvenida.Text = "Bienvenido, Usuario";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.pictureBox1);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(200, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(600, 500);
            this.panelContenido.TabIndex = 1;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 1024);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMenuPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigoDoku - Menú Principal";
            this.panelLateral.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private Button btnCuenta;
        private PictureBox pictureBox1;
    }
}