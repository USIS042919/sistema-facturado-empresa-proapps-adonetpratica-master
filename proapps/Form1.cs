using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proapps
{
    public partial class Form1 : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["clientes"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idCliente"] };
        }
        void mostrarDatos()
        {
            try
            {
                lblidCliente.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtdireccion.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtpagos.Text = tbl.Rows[posicion].ItemArray[5].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;

                 }catch(Exception ex) {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }

            
    }
    

       
        private void btnprimero_Click_1(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnanterior_Click_1(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click_1(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click_1(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
        void limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            txtpagos.Text = "";

        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosClientes.Enabled = !valor;
        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {//boton de nuevo
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar
                String[] valores = {
                    lblidCliente.Text,
                    txtcodigo.Text,
                    txtnombre.Text,
                    txtdireccion.Text,
                    txttelefono.Text,
                    txtpagos.Text,
                    
                };
                objConexion.mantenimiento_datos_clientes(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {//boton de modificar
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombre.Text, "Registro de Clientes",
             MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidCliente.Text };
                objConexion.mantenimiento_datos_clientes(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            busqueda_clientes frmBusquedaClientes = new busqueda_clientes();
            frmBusquedaClientes.ShowDialog();

            if (frmBusquedaClientes._idCliente > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaClientes._idCliente));
                mostrarDatos();
            }
        }

      
    }
}
