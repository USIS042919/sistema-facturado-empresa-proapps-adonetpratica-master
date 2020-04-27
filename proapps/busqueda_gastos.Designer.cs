namespace proapps
{
    partial class busqueda_gastos
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
            this.grdBusquedaGastos = new System.Windows.Forms.DataGridView();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBusquedaGastos
            // 
            this.grdBusquedaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaGastos.Location = new System.Drawing.Point(36, 67);
            this.grdBusquedaGastos.Name = "grdBusquedaGastos";
            this.grdBusquedaGastos.Size = new System.Drawing.Size(681, 375);
            this.grdBusquedaGastos.TabIndex = 12;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(158, 27);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(51, 13);
            this.lblbuscar.TabIndex = 11;
            this.lblbuscar.Text = "BUSCAR";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(215, 24);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(332, 20);
            this.txtbuscar.TabIndex = 10;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(571, 448);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(129, 60);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionar.Location = new System.Drawing.Point(424, 448);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(124, 60);
            this.btnseleccionar.TabIndex = 13;
            this.btnseleccionar.Text = "seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // busqueda_gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(827, 520);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.grdBusquedaGastos);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Name = "busqueda_gastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "busqueda_gastos";
            this.Load += new System.EventHandler(this.busqueda_gastos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.DataGridView grdBusquedaGastos;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}