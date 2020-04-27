namespace proapps
{
    partial class busqueda_empleados
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
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.grdBusquedaEmpleados = new System.Windows.Forms.DataGridView();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(545, 443);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(116, 58);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnseleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseleccionar.Location = new System.Drawing.Point(408, 443);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(103, 58);
            this.btnseleccionar.TabIndex = 8;
            this.btnseleccionar.Text = "seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // grdBusquedaEmpleados
            // 
            this.grdBusquedaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaEmpleados.Location = new System.Drawing.Point(37, 62);
            this.grdBusquedaEmpleados.Name = "grdBusquedaEmpleados";
            this.grdBusquedaEmpleados.Size = new System.Drawing.Size(681, 375);
            this.grdBusquedaEmpleados.TabIndex = 7;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(122, 22);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(51, 13);
            this.lblbuscar.TabIndex = 6;
            this.lblbuscar.Text = "BUSCAR";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(179, 19);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(332, 20);
            this.txtbuscar.TabIndex = 5;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // busqueda_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(874, 513);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.grdBusquedaEmpleados);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Name = "busqueda_empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "busqueda_empleados";
            this.Load += new System.EventHandler(this.busqueda_empleados_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.DataGridView grdBusquedaEmpleados;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}