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
    public partial class frmBusquedaCategorias : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idCategoria;

        public frmBusquedaCategorias()
        {
            InitializeComponent();
        }

        private void frmBusquedaCategorias_Load(object sender, EventArgs e)
        {
            grdBusquedaCategorias.DataSource =
             objConexion.obtener_datos().Tables["categorias"].DefaultView;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaCategorias.RowCount > 0)
            {
                _idCategoria = int.Parse(grdBusquedaCategorias.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaCategorias.DataSource;
            bs.Filter = "categoria like '%" + valor + "%'";
            grdBusquedaCategorias.DataSource = bs;

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }
    }
}
