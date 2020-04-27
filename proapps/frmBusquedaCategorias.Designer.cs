namespace proapps
{
    partial class frmBusquedaCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncancelar = new System.Windows.Forms.Button();
            this.grdBusquedaCategorias = new System.Windows.Forms.DataGridView();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(316, 414);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 31);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // grdBusquedaCategorias
            // 
            this.grdBusquedaCategorias.AllowUserToAddRows = false;
            this.grdBusquedaCategorias.AllowUserToDeleteRows = false;
            this.grdBusquedaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.categoria});
            this.grdBusquedaCategorias.Location = new System.Drawing.Point(20, 56);
            this.grdBusquedaCategorias.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaCategorias.Name = "grdBusquedaCategorias";
            this.grdBusquedaCategorias.ReadOnly = true;
            this.grdBusquedaCategorias.RowHeadersWidth = 102;
            this.grdBusquedaCategorias.RowTemplate.Height = 40;
            this.grdBusquedaCategorias.Size = new System.Drawing.Size(372, 346);
            this.grdBusquedaCategorias.TabIndex = 19;
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "idCategoria";
            this.idCategoria.HeaderText = "ID";
            this.idCategoria.MinimumWidth = 12;
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            this.idCategoria.Width = 250;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "NOMBRE";
            this.categoria.MinimumWidth = 12;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 250;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(100, 14);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(1);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(295, 20);
            this.txtbuscar.TabIndex = 18;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(45, 16);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(54, 13);
            this.lblbuscar.TabIndex = 17;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(220, 414);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 16;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // frmBusquedaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 470);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.grdBusquedaCategorias);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnseleccionar);
            this.Name = "frmBusquedaCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaCategorias";
            this.Load += new System.EventHandler(this.frmBusquedaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView grdBusquedaCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnseleccionar;
    }
}