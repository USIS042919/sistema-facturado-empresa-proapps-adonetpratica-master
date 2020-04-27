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
    public partial class busqueda_empleados : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idEmpleados;
        public busqueda_empleados()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaEmpleados.RowCount > 0)
            {
                _idEmpleados = int.Parse(grdBusquedaEmpleados.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de empleados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaEmpleados.DataSource;
            bs.Filter = "Nombre_empleados like '%" + valor + "%'";
            grdBusquedaEmpleados.DataSource = bs;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void busqueda_empleados_Load_1(object sender, EventArgs e)
        {
            grdBusquedaEmpleados.DataSource =
               objConexion.obtener_datos().Tables["empleados"].DefaultView;
        }
    }
    }

