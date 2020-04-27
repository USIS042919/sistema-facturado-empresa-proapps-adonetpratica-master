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
    public partial class empleados : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public empleados()
        {
            InitializeComponent();
        }
       
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["empleados"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idEmpleados"] };
        }
        void mostrarDatos()
        {
            try
            {
                lblidEmpleados.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtcorreo.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtpagos.Text = tbl.Rows[posicion].ItemArray[5].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }


        }

        void limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txttelefono.Text = "";
            txtcorreo.Text = "";
            txtpagos.Text = "";

        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosEmpleados.Enabled = !valor;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
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
                    lblidEmpleados.Text,
                    txtcodigo.Text,
                    txtnombre.Text,
                    txttelefono.Text,
                    txtcorreo.Text,
                    txtpagos.Text,

                };
                objConexion.mantenimiento_datos_empleados(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

     

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtnombre.Text, "Registro de Empleados",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidEmpleados.Text };
                objConexion.mantenimiento_datos_empleados(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }


        private void empleados_Load_1(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            busqueda_empleados frmBusquedaEmpleados = new busqueda_empleados();
            frmBusquedaEmpleados.ShowDialog();

            if (frmBusquedaEmpleados._idEmpleados > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaEmpleados._idEmpleados));
                mostrarDatos();
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
                MessageBox.Show("Primer Registro...", "Registros de Empleados",
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
                MessageBox.Show("Ultimo Registro...", "Registros de Empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click_1(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }
    }
    }

