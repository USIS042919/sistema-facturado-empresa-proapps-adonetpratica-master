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
    public partial class frmOpciones : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public frmOpciones()
        {
            InitializeComponent();
        }

        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["eventos"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idEvento"] };

            cboCategoriaOpciones.DataSource = objConexion.obtener_datos().Tables["categorias"];
            cboCategoriaOpciones.DisplayMember = "categoria";
            cboCategoriaOpciones.ValueMember = "categorias.idCategoria";

        }
        void mostrarDatos()
        {
            try
            {

                cboCategoriaOpciones.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();
                lblEvento.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txttelefono.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtdireccion.Text = tbl.Rows[posicion].ItemArray[5].ToString();
                txtpagos.Text = tbl.Rows[posicion].ItemArray[6].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar " + ex.Message, "Registros de Cliente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }
        void limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txttelefono.Text = "";
            txtdireccion.Text = "";
            txtpagos.Text = "";
        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosOpciones.Enabled = !valor;
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
                MessageBox.Show("Primer Registro...", "Registros de eventos",
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
                MessageBox.Show("Ultimo Registro...", "Registros de eventos",
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
                    lblEvento.Text,
                    cboCategoriaOpciones.SelectedValue.ToString(),
                    txtcodigo.Text,
                    txtnombre.Text,
                    txttelefono.Text,
                    txtdireccion.Text,
                    txtpagos.Text
                };
                objConexion.mantenimiento_datos_eventos(valores, accion);
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

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();

            cboCategoriaOpciones.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCategoriaOpciones.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnBuscarCategoriaEventos_Click(object sender, EventArgs e)
        {
            frmBusquedaCategorias buscarCategoria = new frmBusquedaCategorias();
            buscarCategoria.ShowDialog();

            if (buscarCategoria._idCategoria > 0)
            {
                cboCategoriaOpciones.SelectedValue = buscarCategoria._idCategoria;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaOpciones buscareventos = new frmBusquedaOpciones();
            buscareventos.ShowDialog();

            if (buscareventos._idOpciones > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(buscareventos._idOpciones));
                mostrarDatos();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina este dato " + txtnombre.Text, "Registro de Clientes",
             MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblEvento.Text };
                objConexion.mantenimiento_datos_eventos(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }
    }
}
