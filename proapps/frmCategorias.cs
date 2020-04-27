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
    public partial class frmCategorias : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["categorias"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idCategoria"] };
        }
        void mostrarDatos()
        {
            try
            {
                lblidCategoria.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtnombre.Text = tbl.Rows[posicion].ItemArray[1].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar " + ex.Message, "Registros de Categorias",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }
        void limpiar_cajas()
        {
            txtnombre.Text = "";
        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosCategorias.Enabled = !valor;
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
                MessageBox.Show("Primer Registro...", "Registros de Categorias",
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
                MessageBox.Show("Ultimo Registro...", "Registros de Categorias",
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
                    lblidCategoria.Text,
                    txtnombre.Text
                };
                objConexion.mantenimiento_datos_categorias(valores, accion);
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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaCategorias busCat = new frmBusquedaCategorias();
            busCat.ShowDialog();

            if (busCat._idCategoria > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(busCat._idCategoria));
                mostrarDatos();
            }
        }
    }
}
