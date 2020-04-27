namespace proapps
{
    partial class frmElementos
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
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.grbDatosElementos = new System.Windows.Forms.GroupBox();
            this.btnBuscarCategoriaEventos = new System.Windows.Forms.Button();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.cboCategoriaElementos = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblidInforme = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.grbEdicion.SuspendLayout();
            this.grbNavegacion.SuspendLayout();
            this.grbDatosElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.btnBuscar);
            this.grbEdicion.Controls.Add(this.btneliminar);
            this.grbEdicion.Controls.Add(this.btnModificar);
            this.grbEdicion.Controls.Add(this.btnNuevo);
            this.grbEdicion.Location = new System.Drawing.Point(379, 361);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Size = new System.Drawing.Size(314, 87);
            this.grbEdicion.TabIndex = 11;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion de Productos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(246, 16);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 56);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(170, 15);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(1);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(74, 56);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(93, 16);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 56);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(2, 16);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(89, 56);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grbNavegacion
            // 
            this.grbNavegacion.Controls.Add(this.lblnregistros);
            this.grbNavegacion.Controls.Add(this.btnultimo);
            this.grbNavegacion.Controls.Add(this.btnsiguiente);
            this.grbNavegacion.Controls.Add(this.btnanterior);
            this.grbNavegacion.Controls.Add(this.btnprimero);
            this.grbNavegacion.Location = new System.Drawing.Point(131, 361);
            this.grbNavegacion.Margin = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Name = "grbNavegacion";
            this.grbNavegacion.Padding = new System.Windows.Forms.Padding(1);
            this.grbNavegacion.Size = new System.Drawing.Size(229, 87);
            this.grbNavegacion.TabIndex = 10;
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
            this.btnultimo.Size = new System.Drawing.Size(40, 55);
            this.btnultimo.TabIndex = 3;
            this.btnultimo.Text = ">|";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(143, 16);
            this.btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(40, 55);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(41, 16);
            this.btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(40, 55);
            this.btnanterior.TabIndex = 1;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(2, 16);
            this.btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(40, 55);
            this.btnprimero.TabIndex = 0;
            this.btnprimero.Text = "|<";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // grbDatosElementos
            // 
            this.grbDatosElementos.Controls.Add(this.btnBuscarCategoriaEventos);
            this.grbDatosElementos.Controls.Add(this.txtcorreo);
            this.grbDatosElementos.Controls.Add(this.lblcorreo);
            this.grbDatosElementos.Controls.Add(this.txttelefono);
            this.grbDatosElementos.Controls.Add(this.lbltelefono);
            this.grbDatosElementos.Controls.Add(this.txtnombre);
            this.grbDatosElementos.Controls.Add(this.lblnombre);
            this.grbDatosElementos.Controls.Add(this.cboCategoriaElementos);
            this.grbDatosElementos.Controls.Add(this.lblCategoria);
            this.grbDatosElementos.Controls.Add(this.lblidInforme);
            this.grbDatosElementos.Controls.Add(this.textBox6);
            this.grbDatosElementos.Controls.Add(this.label6);
            this.grbDatosElementos.Controls.Add(this.txtcodigo);
            this.grbDatosElementos.Controls.Add(this.lblcodigo);
            this.grbDatosElementos.Enabled = false;
            this.grbDatosElementos.Location = new System.Drawing.Point(131, 17);
            this.grbDatosElementos.Margin = new System.Windows.Forms.Padding(1);
            this.grbDatosElementos.Name = "grbDatosElementos";
            this.grbDatosElementos.Padding = new System.Windows.Forms.Padding(1);
            this.grbDatosElementos.Size = new System.Drawing.Size(459, 331);
            this.grbDatosElementos.TabIndex = 9;
            this.grbDatosElementos.TabStop = false;
            this.grbDatosElementos.Text = "Datos de tablas";
            // 
            // btnBuscarCategoriaEventos
            // 
            this.btnBuscarCategoriaEventos.Location = new System.Drawing.Point(250, 35);
            this.btnBuscarCategoriaEventos.Margin = new System.Windows.Forms.Padding(1);
            this.btnBuscarCategoriaEventos.Name = "btnBuscarCategoriaEventos";
            this.btnBuscarCategoriaEventos.Size = new System.Drawing.Size(128, 26);
            this.btnBuscarCategoriaEventos.TabIndex = 27;
            this.btnBuscarCategoriaEventos.Text = "Buscar Categorias";
            this.btnBuscarCategoriaEventos.UseVisualStyleBackColor = true;
            this.btnBuscarCategoriaEventos.Click += new System.EventHandler(this.btnBuscarCategoriaEventos_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(86, 180);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(1);
            this.txtcorreo.Multiline = true;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(282, 30);
            this.txtcorreo.TabIndex = 24;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(13, 197);
            this.lblcorreo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(56, 13);
            this.lblcorreo.TabIndex = 23;
            this.lblcorreo.Text = "CORREO:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(87, 145);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(1);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(81, 20);
            this.txttelefono.TabIndex = 20;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(19, 148);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(30, 13);
            this.lbltelefono.TabIndex = 19;
            this.lbltelefono.Text = "TEL:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(87, 110);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(1);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(205, 20);
            this.txtnombre.TabIndex = 18;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(14, 113);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(57, 13);
            this.lblnombre.TabIndex = 16;
            this.lblnombre.Text = "NOMBRE:";
            // 
            // cboCategoriaElementos
            // 
            this.cboCategoriaElementos.FormattingEnabled = true;
            this.cboCategoriaElementos.Location = new System.Drawing.Point(87, 39);
            this.cboCategoriaElementos.Margin = new System.Windows.Forms.Padding(1);
            this.cboCategoriaElementos.Name = "cboCategoriaElementos";
            this.cboCategoriaElementos.Size = new System.Drawing.Size(154, 21);
            this.cboCategoriaElementos.TabIndex = 14;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(13, 39);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "CATEGORIA:";
            // 
            // lblidInforme
            // 
            this.lblidInforme.AutoSize = true;
            this.lblidInforme.Location = new System.Drawing.Point(190, 78);
            this.lblidInforme.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblidInforme.Name = "lblidInforme";
            this.lblidInforme.Size = new System.Drawing.Size(21, 13);
            this.lblidInforme.TabIndex = 12;
            this.lblidInforme.Text = "ID:";
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
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(87, 71);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(1);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(76, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(15, 78);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(52, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "CODIGO:";
            // 
            // frmElementos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(754, 473);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.grbNavegacion);
            this.Controls.Add(this.grbDatosElementos);
            this.Name = "frmElementos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENIMIENTO ELEMENTOS";
            this.Load += new System.EventHandler(this.frmElementos_Load);
            this.grbEdicion.ResumeLayout(false);
            this.grbNavegacion.ResumeLayout(false);
            this.grbNavegacion.PerformLayout();
            this.grbDatosElementos.ResumeLayout(false);
            this.grbDatosElementos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grbNavegacion;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.GroupBox grbDatosElementos;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.ComboBox cboCategoriaElementos;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblidInforme;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button btnBuscarCategoriaEventos;
    }
}