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
    public partial class frmBusquedaFormas : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idforma;
        public frmBusquedaFormas()
        {
            InitializeComponent();
        }

        private void frmBusquedaFormas_Load(object sender, EventArgs e)
        {
            grdBusquedaFormas.DataSource =
             objConexion.obtener_datos().Tables["formas"].DefaultView;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaFormas.RowCount > 0)
            {
                _idforma = int.Parse(grdBusquedaFormas.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaFormas.DataSource;
            bs.Filter = "formas like '%" + valor + "%'";
            grdBusquedaFormas.DataSource = bs;

            //el problema con este metodo de filtro que si no hay registros dat error
            //grdBusquedaClientes.DataSource = objConexion.obtener_datos().Tables["clientes"].Select("nombre like '%" + valor + "%'").CopyToDataTable();
        }

    }
}
