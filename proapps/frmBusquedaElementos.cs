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
   
    public partial class frmBusquedaElementos : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idInforme;
        public frmBusquedaElementos()
        {
            InitializeComponent();
        }

        private void frmBusquedaElementos_Load(object sender, EventArgs e)
        {
            grdBusquedaInforme.DataSource = objConexion.obtener_datos().Tables["informe_formas"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaInforme.DataSource;
            bs.Filter = "formas like '%" + valor + "%' or codigo like '%" + valor + "%' or nombre like '%" + valor + "%'";
            grdBusquedaInforme.DataSource = bs;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaInforme.RowCount > 0)
            {
                _idInforme = int.Parse(grdBusquedaInforme.CurrentRow.Cells["idInforme"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
