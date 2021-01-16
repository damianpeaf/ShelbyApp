using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Rol
    {
        MySqlConnection cn;

        public DataTable CrearCombo()
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string sql = "SELECT idRol, nombre FROM rol";

                    MySqlCommand cmd = new MySqlCommand(sql, cn);

                    MySqlDataAdapter mysqldt = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    mysqldt.Fill(dt);

                    return dt;

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("" + ex);
                return null;
            }
            finally
            {
                cn.Close();
            }

        }

    }
}
