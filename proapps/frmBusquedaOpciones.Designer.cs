namespace proapps
{
    partial class frmBusquedaOpciones
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
            this.grdBusquedaOpciones = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnseleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaOpciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(594, 428);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(1);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 31);
            this.btncancelar.TabIndex = 20;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // grdBusquedaOpciones
            // 
            this.grdBusquedaOpciones.AllowUserToAddRows = false;
            this.grdBusquedaOpciones.AllowUserToDeleteRows = false;
            this.grdBusquedaOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaOpciones.Location = new System.Drawing.Point(60, 66);
            this.grdBusquedaOpciones.Margin = new System.Windows.Forms.Padding(1);
            this.grdBusquedaOpciones.Name = "grdBusquedaOpciones";
            this.grdBusquedaOpciones.ReadOnly = true;
            this.grdBusquedaOpciones.RowHeadersWidth = 102;
            this.grdBusquedaOpciones.RowTemplate.Height = 40;
            this.grdBusquedaOpciones.Size = new System.Drawing.Size(611, 346);
            this.grdBusquedaOpciones.TabIndex = 19;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(140, 24);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(1);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(295, 20);
            this.txtbuscar.TabIndex = 18;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(85, 27);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(54, 13);
            this.lblbuscar.TabIndex = 17;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(498, 428);
            this.btnseleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(94, 31);
            this.btnseleccionar.TabIndex = 16;
            this.btnseleccionar.Text = "SELECCIONAR";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // frmBusquedaOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 482);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.grdBusquedaOpciones);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnseleccionar);
            this.Name = "frmBusquedaOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaOpciones";
            this.Load += new System.EventHandler(this.frmBusquedaOpciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaOpciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView grdBusquedaOpciones;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnseleccionar;
    }
}