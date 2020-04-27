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
    public partial class frmBusquedaOpciones : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idOpciones;
        public frmBusquedaOpciones()
        {
            InitializeComponent();
        }

        private void frmBusquedaOpciones_Load(object sender, EventArgs e)
        {
            grdBusquedaOpciones.DataSource = objConexion.obtener_datos().Tables["eventos_categorias"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaOpciones.DataSource;
            bs.Filter = "categoria like '%" + valor + "%' or codigo like '%" + valor + "%' or nombre like '%" + valor + "%'";
            grdBusquedaOpciones.DataSource = bs;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaOpciones.RowCount > 0)
            {
                _idOpciones = int.Parse(grdBusquedaOpciones.CurrentRow.Cells["idEventos"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de eventos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
