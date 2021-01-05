using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Movimiento
    {
        MySqlConnection cn;
        DataSet ds;

        public bool crearMovimientoAro(string idDetalleAro, string idSucursal, string cantidad, string fecha, string idTipoMovimiento)
        {
                try
                {
                    using (cn = new Conexion().IniciarConexion())
                    {
                        MySqlCommand comando = new MySqlCommand($"INSERT INTO movimiento VALUES(null,{idDetalleAro},null, {idSucursal}, {cantidad}, '{fecha}', {idTipoMovimiento})", cn);
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("" + ex);
                    return false;
                }
                finally
                {
                    cn.Close();
                }

        }
    }
}
