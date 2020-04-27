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
    public partial class busqueda_gastos : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idgastos;
        public busqueda_gastos()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaGastos.RowCount > 0)
            {
                _idgastos = int.Parse(grdBusquedaGastos.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de gastos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaGastos.DataSource;
            bs.Filter = "Nombre_gastos like '%" + valor + "%'";
            grdBusquedaGastos.DataSource = bs;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void busqueda_gastos_Load_1(object sender, EventArgs e)
        {
            grdBusquedaGastos.DataSource =
               objConexion.obtener_datos().Tables["gastos"].DefaultView;
        }
    }
    }

