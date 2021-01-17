using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class InventarioBodega
    {
        MySqlConnection cn;
        DataSet ds;

        public bool crearDisponibilidadDesdeAro(string idDetalle, string idUsuario)
        {
            try
            {
                string cantidad = "0";

                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand cmd1 = new MySqlCommand($"SELECT idBodega, idSucursal FROM bodega", cn);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.HasRows)
                    {

                        while (reader1.Read())
                        {
                            cn = new Conexion().IniciarConexion();

                            //stock inicial por cada tienda

                            string idBodega = reader1.GetString(0);
                            string idSucursal = reader1.GetString(1);

                            string sql = $"INSERT INTO Aro (idAro, idDetalleAro, cantidad, usuarioModificacion, idSucursal, idBodega) VALUES (null, {idDetalle}, {cantidad}, {idUsuario}, {idSucursal}, {idBodega})";

                            Console.WriteLine(sql);
                            
                            MySqlCommand cmd = new MySqlCommand(sql, cn);
                            cmd.ExecuteNonQuery();

                            Movimiento movimiento = new Movimiento();

                            DateTime dateValue = DateTime.Now;
                            string fecha = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

                            //modificar aca
                            //movimiento.crearMovimientoInventarioBodega(idDetalle, idSucursal, cantidad, fecha, "1");

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

        public bool crearDisponibilidadDesdeLlanta(string idDetalle, string idUsuario)
        {
            try
            {
                string cantidad = "0";

                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand cmd1 = new MySqlCommand($"SELECT idBodega, idSucursal FROM bodega", cn);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.HasRows)
                    {

                        while (reader1.Read())
                        {
                            cn = new Conexion().IniciarConexion();

                            //stock inicial por cada tienda


                            string idBodega = reader1.GetString(0);
                            string idSucursal = reader1.GetString(1);

                            string sql = $"INSERT INTO llanta (idLlanta, idDetalleLlanta, cantidad, usuarioModificacion, idSucursal, idBodega) VALUES (null, {idDetalle}, {cantidad}, {idUsuario}, {idSucursal},{idBodega})";
                            MySqlCommand cmd = new MySqlCommand(sql, cn);
                            cmd.ExecuteNonQuery();

                            Movimiento movimiento = new Movimiento();

                            DateTime dateValue = DateTime.Now;
                            string fecha = dateValue.ToString("yyyy-MM-dd HH:mm:ss");
                            //modificar aca
                            //movimiento.crearMovimientoInventarioBodega(idDetalle, idSucursal, cantidad, fecha, "1");

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

        public bool crearDisponibilidadDesdeBodega(string idBodega, string idUsuario)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string idSucursal = "";

                    MySqlCommand cmd = new MySqlCommand($"SELECT idSucursal FROM bodega where idBodega={idBodega}", cn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        idSucursal = reader.GetString(0);
                    }

                    cn.Close();
                    cn = new Conexion().IniciarConexion();


                    MySqlCommand cmd1 = new MySqlCommand($"SELECT idDetalleAro FROM detalleAro", cn);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.HasRows)
                    {

                        while (reader1.Read())
                        {
                            cn = new Conexion().IniciarConexion();

                            string cantidad = "0";

                            string idDetalle = reader1.GetString(0);
                            string sql = $"INSERT INTO aro (idAro, idDetalleAro, cantidad, usuarioModificacion, idSucursal, idBodega) VALUES (null, {idDetalle}, {cantidad}, {idUsuario}, {idSucursal}, {idBodega})";
                            MySqlCommand cmd3 = new MySqlCommand(sql, cn);
                            cmd3.ExecuteNonQuery();
                        }
                        cn.Close();
                    
                    }

                    cn = new Conexion().IniciarConexion();

                    MySqlCommand cmd2 = new MySqlCommand($"SELECT idDetalleLlanta FROM detalleLlanta", cn);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                        if (reader2.HasRows)
                        {

                            while (reader2.Read())
                            {
                                cn = new Conexion().IniciarConexion();

                                string cantidad = "0";

                                string idDetalle = reader1.GetString(0);
                                string sql = $"INSERT INTO llanta (idLlanta, idDetalleLlanta, cantidad, usuarioModificacion, idSucursal, idBodega) VALUES (null, {idDetalle}, {cantidad}, {idUsuario}, {idSucursal}, {idBodega})";
                                MySqlCommand cmd4 = new MySqlCommand(sql, cn);
                                cmd4.ExecuteNonQuery();
                            }
                            cn.Close();
                        }

                    return true;
                    
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
