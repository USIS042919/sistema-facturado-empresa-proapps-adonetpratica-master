using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria para trabajar con base de datos
using System.Data;
using System.Data.SqlClient;//libreria para conextar a una base de datos de SQL server

namespace proapps
{
    class Conexion_db
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public Conexion_db()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sistema_db.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }
        public DataSet obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "clientes");

            comandosSQL.CommandText = "select * from empleados";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "empleados");


            comandosSQL.CommandText = "select * from gastos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "gastos");

            comandosSQL.CommandText = "select * from eventos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "eventos");

            comandosSQL.CommandText = "select * from categorias";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "categorias");

            comandosSQL.CommandText = "select * from formas";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "formas");

            comandosSQL.CommandText = "select * from informe";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "informe");

            comandosSQL.CommandText = "select categorias.categoria, eventos.idEvento, eventos.codigo, eventos.nombre, eventos.telefono, eventos.direccion, eventos.deposito from eventos inner join categorias on(categorias.idCategoria=eventos.idCategoria)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "eventos_categorias");

            comandosSQL.CommandText = "select formas.formas, informe.idInforme, informe.codigo, informe.nombre, informe.telefono, informe.correo from informe inner join formas on(formas.idforma=informe.idforma)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "informe_formas");

            return ds;
        }
        public void mantenimiento_datos_clientes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO clientes (codigo,nombre,direccion,telefono,pago) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE clientes SET " +
                    "codigo         = '" + datos[1] + "'," +
                    "nombre         = '" + datos[2] + "'," +
                    "direccion      = '" + datos[3] + "'," +
                    "telefono       = '" + datos[4] + "'," +
                    "pago          = '" + datos[5] + "'" +
                    "WHERE idCliente = '" + datos[0] + "'";

            }
            else if (accion == "eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE idCliente='" + datos[0] + "'";

            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_empleados(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO empleados (codigo,nombre,telefono,correo,pagos) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE empleados SET " +
                    "codigo         = '" + datos[1] + "'," +
                    "nombre         = '" + datos[2] + "'," +
                    "telefono      = '" + datos[3] + "'," +
                    "correo       = '" + datos[4] + "'," +
                    "pagos          = '" + datos[5] + "'" +
                    "WHERE idEmpleados = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE empleados FROM empleados WHERE idEmpleados='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_gastos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO gastos (gastos_de_tramsportes,gastos_de_comida,gastos_de_vestimenta,gastos_de_ecenario) VALUES(" +
                   "'" + datos[1] + "'," +
                   "'" + datos[2] + "'," +
                   "'" + datos[3] + "'," +
                   "'" + datos[4] + "'" +
                   ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE gastos SET " +
                  "gastos_de_tramsportes   = '" + datos[1] + "'," +
                  "gastos_de_comida        = '" + datos[2] + "'," +
                  "gastos_de_vestimenta    = '" + datos[3] + "'," +
                  "gastos_de_ecenario    = '" + datos[4] + "'" +
                  "WHERE idgastos = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE gastos FROM gastos WHERE idgastos='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        public void mantenimiento_datos_eventos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO eventos (idCategoria,codigo,nombre,telefono,direccion,deposito) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                     "'" + datos[5] + "'," +
                    "'" + datos[6] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE eventos SET " +
                    "idCategoria      = '" + datos[1] + "'," +
                    "codigo           = '" + datos[2] + "'," +
                    "nombre           = '" + datos[3] + "'," +
                    "telefono            = '" + datos[4] + "'," +
                    "direccion           = '" + datos[5] + "'," +
                    "deposito    = '" + datos[6] + "'" +
                    "WHERE idEvento   = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE eventos FROM eventos WHERE idEvento='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_informe(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO informe (idforma,codigo,nombre,telefono,correo) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE informe SET " +
                    "idforma         = '" + datos[1] + "'," +
                    "codigo         = '" + datos[2] + "'," +
                    "nombre      = '" + datos[3] + "'," +
                    "telefono      = '" + datos[4] + "'," +
                    "correo          = '" + datos[5] + "'" +
                    "WHERE idInforme = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE informe FROM informe WHERE idInforme='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_categorias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO categorias (categoria) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE categorias SET " +
                    "categoria            = '" + datos[1] + "'" +
                    "WHERE idCategoria = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE productos FROM categorias WHERE idCategoria='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        public void mantenimiento_datos_formas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO formas (formas) VALUES(" +
                    "'" + datos[1] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE formas SET " +
                    "formas            = '" + datos[1] + "'" +
                    "WHERE idforma = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE informe FROM formas WHERE idforma='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }
        void procesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }


    }
}
