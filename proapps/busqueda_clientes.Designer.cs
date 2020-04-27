namespace proapps
{
    partial class busqueda_clientes
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
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.grdBusquedaClientes = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(94, 23);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(332, 20);
            this.txtbuscar.TabIndex = 0;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged_1);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(37, 26);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(51, 13);
            this.lblbuscar.TabIndex = 1;
            this.lblbuscar.Text = "BUSCAR";
            // 
            // grdBusquedaClientes
            // 
            this.grdBusquedaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaClientes.Location = new System.Drawing.Point(12, 66);
            this.grdBusquedaClientes.Name = "grdBusquedaClientes";
            this.grdBusquedaClientes.Size = new System.Drawing.Size(681, 375);
            this.grdBusquedaClientes.TabIndex = 2;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionar.Location = new System.Drawing.Point(308, 447);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(118, 59);
            this.btnseleccionar.TabIndex = 3;
            this.btnseleccionar.Text = "seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click_1);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(455, 447);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(121, 59);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
            // 
            // busqueda_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(772, 510);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.grdBusquedaClientes);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Name = "busqueda_clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "busqueda_clientes";
            this.Load += new System.EventHandler(this.busqueda_clientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.DataGridView grdBusquedaClientes;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.Button btncancelar;
    }
}