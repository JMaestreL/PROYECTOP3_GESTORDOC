using System.Windows.Forms;

namespace PRESENTATION
{
    partial class FormBuscarDocumento
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTituloFiltro;
        private TextBox txtTituloFiltro;
        private Label lblAutorFiltro;
        private TextBox txtAutorFiltro;
        private Label lblTipoFiltro;
        private ComboBox comboTipoFiltro;
        private Button btnBuscar;
        private DataGridView dgvResultados;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTituloFiltro = new System.Windows.Forms.Label();
            this.txtTituloFiltro = new System.Windows.Forms.TextBox();
            this.lblAutorFiltro = new System.Windows.Forms.Label();
            this.txtAutorFiltro = new System.Windows.Forms.TextBox();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.comboTipoFiltro = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFiltro
            // 
            this.lblTituloFiltro.Location = new System.Drawing.Point(20, 20);
            this.lblTituloFiltro.Name = "lblTituloFiltro";
            this.lblTituloFiltro.Size = new System.Drawing.Size(66, 23);
            this.lblTituloFiltro.TabIndex = 0;
            this.lblTituloFiltro.Text = "Título:";
            // 
            // txtTituloFiltro
            // 
            this.txtTituloFiltro.Location = new System.Drawing.Point(92, 18);
            this.txtTituloFiltro.Name = "txtTituloFiltro";
            this.txtTituloFiltro.Size = new System.Drawing.Size(178, 26);
            this.txtTituloFiltro.TabIndex = 1;
            // 
            // lblAutorFiltro
            // 
            this.lblAutorFiltro.Location = new System.Drawing.Point(281, 20);
            this.lblAutorFiltro.Name = "lblAutorFiltro";
            this.lblAutorFiltro.Size = new System.Drawing.Size(53, 23);
            this.lblAutorFiltro.TabIndex = 2;
            this.lblAutorFiltro.Text = "Autor:";
            // 
            // txtAutorFiltro
            // 
            this.txtAutorFiltro.Location = new System.Drawing.Point(340, 18);
            this.txtAutorFiltro.Name = "txtAutorFiltro";
            this.txtAutorFiltro.Size = new System.Drawing.Size(200, 26);
            this.txtAutorFiltro.TabIndex = 3;
            // 
            // lblTipoFiltro
            // 
            this.lblTipoFiltro.Location = new System.Drawing.Point(546, 20);
            this.lblTipoFiltro.Name = "lblTipoFiltro";
            this.lblTipoFiltro.Size = new System.Drawing.Size(48, 23);
            this.lblTipoFiltro.TabIndex = 4;
            this.lblTipoFiltro.Text = "Tipo:";
            // 
            // comboTipoFiltro
            // 
            this.comboTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoFiltro.Location = new System.Drawing.Point(600, 18);
            this.comboTipoFiltro.Name = "comboTipoFiltro";
            this.comboTipoFiltro.Size = new System.Drawing.Size(150, 28);
            this.comboTipoFiltro.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(770, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 38);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeight = 34;
            this.dgvResultados.Location = new System.Drawing.Point(20, 60);
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 62;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(800, 400);
            this.dgvResultados.TabIndex = 7;
            this.dgvResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellContentClick);
            this.dgvResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultados_CellDoubleClick);
            // 
            // FormBuscarDocumento
            // 
            this.Controls.Add(this.lblTituloFiltro);
            this.Controls.Add(this.txtTituloFiltro);
            this.Controls.Add(this.lblAutorFiltro);
            this.Controls.Add(this.txtAutorFiltro);
            this.Controls.Add(this.lblTipoFiltro);
            this.Controls.Add(this.comboTipoFiltro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvResultados);
            this.Name = "FormBuscarDocumento";
            this.Size = new System.Drawing.Size(850, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
