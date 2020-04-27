namespace proapps
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbDatosClientes = new System.Windows.Forms.GroupBox();
            this.lblidCliente = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpagos = new System.Windows.Forms.TextBox();
            this.lblpagos = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.grbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.grbDatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblnregistros);
            this.grbNavegacion.Controls.Add(this.btnultimo);
            this.grbNavegacion.Controls.Add(this.btnsiguiente);
            this.grbNavegacion.Controls.Add(this.btnanterior);
            this.grbNavegacion.Controls.Add(this.btnprimero);
            this.grbNavegacion.Location = new System.Drawing.Point(32, 393);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Size = new System.Drawing.Size(236, 87);
            this.grbNavegacion.TabIndex = 6;
            this.grbNavegacion.TabStop = false;
            this.grbNavegacion.Text = "Navegacion";
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(83, 26);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
            this.lblnregistros.TabIndex = 13;
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(182, 16);
            this.btnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(40, 49);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click_1);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(143, 16);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 49);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click_1);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(41, 16);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 49);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click_1);
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(2, 16);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(40, 49);
            this.btnprimero.TabIndex = 0;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click_1);
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnBuscar);
            this.grbEdicion.Controls.Add(this.btneliminar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnNuevo);
            this.grbEdicion.Location = new System.Drawing.Point(298, 393);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Size = new System.Drawing.Size(323, 87);
            this.grbEdicion.TabIndex = 5;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion de Clientes";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(247, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 60);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(173, 15);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(72, 60);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(95, 15);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(76, 60);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(11, 16);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(82, 59);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // grbDatosClientes
            // 
            this.grbDatosClientes.Controls.Add(this.lblidCliente);
            this.grbDatosClientes.Controls.Add(this.textBox6);
            this.grbDatosClientes.Controls.Add(this.label6);
            this.grbDatosClientes.Controls.Add(this.txtpagos);
            this.grbDatosClientes.Controls.Add(this.lblpagos);
            this.grbDatosClientes.Controls.Add(this.txttelefono);
            this.grbDatosClientes.Controls.Add(this.lbltelefono);
            this.grbDatosClientes.Controls.Add(this.txtdireccion);
            this.grbDatosClientes.Controls.Add(this.lbldireccion);
            this.grbDatosClientes.Controls.Add(this.txtnombre);
            this.grbDatosClientes.Controls.Add(this.lblnombre);
            this.grbDatosClientes.Controls.Add(this.txtcodigo);
            this.grbDatosClientes.Controls.Add(this.lblcodigo);
            this.grbDatosClientes.Enabled = false;
            this.grbDatosClientes.Location = new System.Drawing.Point(32, 49);
            this.grbDatosClientes.Margin = new System.Windows.Forms.Padding(1);
            this.grbDatosClientes.Name = "grbDatosClientes";
            this.grbDatosClientes.Padding = new System.Windows.Forms.Padding(1);
            this.grbDatosClientes.Size = new System.Drawing.Size(691, 331);
            this.grbDatosClientes.TabIndex = 5;
            this.grbDatosClientes.TabStop = false;
            this.grbDatosClientes.Text = "Datos de Cliente";
            // 
            // lblidCliente
            // 
            this.lblidCliente.AutoSize = true;
            this.lblidCliente.Location = new System.Drawing.Point(167, 36);
            this.lblidCliente.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidCliente.Name = "lblidCliente";
            this.lblidCliente.Size = new System.Drawing.Size(21, 13);
            this.lblidCliente.TabIndex = 12;
            this.lblidCliente.Text = "ID:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 568);
            this.textBox6.Margin = new System.Windows.Forms.Padding(1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 20);
            this.textBox6.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 568);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            // 
            // txtpagos
            // 
            this.txtpagos.Location = new System.Drawing.Point(82, 218);
            this.txtpagos.Margin = new System.Windows.Forms.Padding(1);
            this.txtpagos.Name = "txtpagos";
            this.txtpagos.Size = new System.Drawing.Size(137, 20);
            this.txtpagos.TabIndex = 7;
            // 
            // lblpagos
            // 
            this.lblpagos.AutoSize = true;
            this.lblpagos.Location = new System.Drawing.Point(18, 220);
            this.lblpagos.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblpagos.Name = "lblpagos";
            this.lblpagos.Size = new System.Drawing.Size(47, 13);
            this.lblpagos.TabIndex = 6;
            this.lblpagos.Text = "PAGOS:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(82, 186);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(1);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(81, 20);
            this.txttelefono.TabIndex = 5;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(13, 186);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(30, 13);
            this.lbltelefono.TabIndex = 4;
            this.lbltelefono.Text = "TEL:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(82, 89);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(1);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(282, 85);
            this.txtdireccion.TabIndex = 3;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(13, 103);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(69, 13);
            this.lbldireccion.TabIndex = 2;
            this.lbldireccion.Text = "DIRECCION:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(82, 63);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(1);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(205, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(13, 66);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(82, 35);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(1);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(76, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(15, 35);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(52, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "CODIGO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(820, 504);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatosClientes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENIMIENTO CLIENTE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbEdicion.ResumeLayout(false);
            this.grbDatosClientes.ResumeLayout(false);
            this.grbDatosClientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.GroupBox grbDatosClientes;
        private System.Windows.Forms.Label lblidCliente;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpagos;
        private System.Windows.Forms.Label lblpagos;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
    }
}

