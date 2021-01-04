using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Aro
    {
        MySqlConnection cn;

        public bool crearDisponibilidadDesdeAro(string idDetalle, string idUsuario)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand cmd1 = new MySqlCommand($"SELECT idSucursal FROM sucursal", cn);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.HasRows)
                    {

                        while (reader1.Read())
                        {
                            cn = new Conexion().IniciarConexion();

                            string idSucursal = reader1.GetString(0);
                            string sql = $"INSERT INTO aro (idAro, idDetalleAro, cantidad, usuarioModificacion, idSucursal) VALUES (null, {idDetalle}, 0, {idUsuario}, {idSucursal})";
                            MySqlCommand cmd = new MySqlCommand(sql, cn);
                            cmd.ExecuteNonQuery();
                        }
                        return true;
                    }
                    else
                    {
                        return true;
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


        public bool crearDisponibilidadDesdeSucursal(string idSucursal, string idUsuario)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand cmd1 = new MySqlCommand($"SELECT idDetalleAro FROM detalleAro", cn);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.HasRows)
                    {

                        while (reader1.Read())
                        {
                            cn = new Conexion().IniciarConexion();

                            string idDetalle = reader1.GetString(0);
                            string sql = $"INSERT INTO aro (idAro, idDetalleAro, cantidad, usuarioModificacion, idSucursal) VALUES (null, {idDetalle}, 0, {idUsuario}, {idSucursal})";
                            MySqlCommand cmd = new MySqlCommand(sql, cn);
                            cmd.ExecuteNonQuery();
                        }
                        return true;
                    }
                    else
                    {
                        return true;
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
