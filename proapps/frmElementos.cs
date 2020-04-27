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
    public partial class frmElementos : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();

        public frmElementos()
        {
            InitializeComponent();
        }

      
        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Instrumentos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Instrumentos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
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
                    lblidInforme.Text,
                    cboCategoriaElementos.SelectedValue.ToString(),
                    txtcodigo.Text,
                    txtnombre.Text,
                    txttelefono.Text,
                    txtcorreo.Text,
                    
                };
                objConexion.mantenimiento_datos_informe(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina este dato " + txtnombre.Text, "Registro de Clientes",
             MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidInforme.Text };
                objConexion.mantenimiento_datos_informe(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaElementos buscarProducto = new frmBusquedaElementos();
            buscarProducto.ShowDialog();

            if (buscarProducto._idInforme > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(buscarProducto._idInforme));
                mostrarDatos();
            }
        }

        private void frmElementos_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();

            cboCategoriaElementos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCategoriaElementos.AutoCompleteSource = AutoCompleteSource.ListItems;
            
        }
        void actualizarDs()
        {

            tbl = objConexion.obtener_datos().Tables["informe"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idInforme"] };

            cboCategoriaElementos.DataSource = objConexion.obtener_datos().Tables["formas"];
            cboCategoriaElementos.DisplayMember = "formas";
            cboCategoriaElementos.ValueMember = "formas.idforma";
        }
        void mostrarDatos()
        {
            try
            {

                cboCategoriaElementos.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

                lblidInforme.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtcorreo.Text = tbl.Rows[posicion].ItemArray[5].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar " + ex.Message, "Registros de empleados",
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
        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosElementos.Enabled = !valor;
        }

        private void btnBuscarCategoriaEventos_Click(object sender, EventArgs e)
        {
            frmBusquedaFormas buscarformas = new frmBusquedaFormas();
            buscarformas.ShowDialog();

            if (buscarformas._idforma > 0)
            {
                cboCategoriaElementos.SelectedValue = buscarformas._idforma;
            }
        }
    }
}   
