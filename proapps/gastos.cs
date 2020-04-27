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
    public partial class gastos : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public gastos()
        {
            InitializeComponent();
        }
      
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["gastos"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idgastos"] };
        }
        void mostrarDatos()
        {
            try
            {
                lblidgastos.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txttransporte.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtcomida.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtvestuario.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtecenario.Text = tbl.Rows[posicion].ItemArray[4].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Gastos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }

       
        void limpiar_cajas()
        {
            txttransporte.Text = "";
            txtcomida.Text = "";
            txtvestuario.Text = "";
            txtecenario.Text = "";
           

        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosGastos.Enabled = !valor;
        }
     
        private void gastos_Load_1(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
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
                MessageBox.Show("Primer Registro...", "Registros de Gastos",
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
                MessageBox.Show("Ultimo Registro...", "Registros de gastos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click_1(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
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
                    lblidgastos.Text,
                    txttransporte.Text,
                    txtcomida.Text,
                    txtvestuario.Text,
                    txtecenario.Text,


                };
                objConexion.mantenimiento_datos_gastos(valores, accion);
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
            if (MessageBox.Show("Esta seguro de elimina a " + txttransporte.Text, "Registro de Gastos",
         MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidgastos.Text };
                objConexion.mantenimiento_datos_gastos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            busqueda_gastos frmBusquedaGastos = new busqueda_gastos();
            frmBusquedaGastos.ShowDialog();

            if (frmBusquedaGastos._idgastos > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaGastos._idgastos));
                mostrarDatos();
            }
        }

        
    }
}
