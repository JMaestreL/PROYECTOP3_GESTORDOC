using System.Windows.Forms;

namespace PRESENTATION
{
    partial class FormSubirDocumento
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSeleccionarImagen;
        private Button btnExtraerTexto;
        private Button btnGuardar;
        private PictureBox pictureBox1;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtDescripcion;
        private ComboBox comboTipo;
        private TextBox txtContenido;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblDescripcion;
        private Label lblTipo;
        private Label lblContenido;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.btnExtraerTexto = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(20, 230);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarImagen.TabIndex = 1;
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen";
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // btnExtraerTexto
            // 
            this.btnExtraerTexto.Location = new System.Drawing.Point(20, 270);
            this.btnExtraerTexto.Name = "btnExtraerTexto";
            this.btnExtraerTexto.Size = new System.Drawing.Size(75, 23);
            this.btnExtraerTexto.TabIndex = 2;
            this.btnExtraerTexto.Text = "Extraer Texto (OCR)";
            this.btnExtraerTexto.Click += new System.EventHandler(this.btnExtraerTexto_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(300, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Documento";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(380, 20);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(250, 26);
            this.txtTitulo.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(380, 60);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(250, 26);
            this.txtAutor.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(380, 100);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(250, 26);
            this.txtDescripcion.TabIndex = 9;
            // 
            // comboTipo
            // 
            this.comboTipo.Location = new System.Drawing.Point(430, 140);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(200, 28);
            this.comboTipo.TabIndex = 11;
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(300, 200);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContenido.Size = new System.Drawing.Size(330, 150);
            this.txtContenido.TabIndex = 13;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(300, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            this.lblAutor.Location = new System.Drawing.Point(300, 60);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(100, 23);
            this.lblAutor.TabIndex = 6;
            this.lblAutor.Text = "Autor:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(300, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 23);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblTipo
            // 
            this.lblTipo.Location = new System.Drawing.Point(300, 140);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(100, 23);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo de Documento:";
            // 
            // lblContenido
            // 
            this.lblContenido.Location = new System.Drawing.Point(300, 180);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(100, 23);
            this.lblContenido.TabIndex = 12;
            this.lblContenido.Text = "Texto extraído:";
            // 
            // FormSubirDocumento
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.btnExtraerTexto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.txtContenido);
            this.Name = "FormSubirDocumento";
            this.Size = new System.Drawing.Size(660, 420);
            this.Load += new System.EventHandler(this.FormSubirDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
