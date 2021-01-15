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

        public DataSet ListarTodos()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = "SELECT S.nombre as 'Sucursal',  D.idDetalleInventarioBodega as 'ID InventarioBodega', D.codigo as 'Codigo', A.cantidad as 'Stock',D.diseno, D.medida, D.pcd, D.pcd2, U.nombre as 'Firma',DATE_FORMAT(A.fechaModificacion, '%d/%m/%Y %H:%i')  as 'Ultima modificacion', A.idInventarioBodega as 'ID específica', D.precio, D.costo  FROM InventarioBodega A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleInventarioBodega D on D.idDetalleInventarioBodega = A.idDetalleInventarioBodega inner join usuario U on A.usuarioModificacion = U.idUsuario";

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    MySqlDataAdapter m_datos = new MySqlDataAdapter(datos);
                    ds = new DataSet();
                    m_datos.Fill(ds);

                    return ds;

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

        public DataSet buscarInventarioBodega(string idSucursal, string idDetalle, string codigo, string diseno, bool todas)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT S.nombre as 'Sucursal',  D.idDetalleInventarioBodega as 'ID InventarioBodega', D.codigo as 'Codigo', A.cantidad as 'Stock',D.diseno, D.medida, D.pcd, D.pcd2, U.nombre as 'Firma', DATE_FORMAT(A.fechaModificacion, '%d/%m/%Y %H:%i') as 'Ultima modificacion', A.idInventarioBodega as 'ID específica', D.precio, D.costo  FROM InventarioBodega A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleInventarioBodega D on D.idDetalleInventarioBodega = A.idDetalleInventarioBodega inner join usuario U on A.usuarioModificacion = U.idUsuario ";

                    if (todas)
                    {
                        comando += $"where S.idSucursal like '%%'";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $"and D.idDetalleInventarioBodega like '{idDetalle}'";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $"and D.codigo like '{codigo}'";
                        }

                        if (!string.IsNullOrEmpty(diseno))
                        {
                            comando += $"and D.diseno like '%{diseno}%'";
                        }
                    }
                    else
                    {
                        comando += $"where S.idSucursal like '{idSucursal}'";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $"and D.idDetalleInventarioBodega like '{idDetalle}'";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $"and D.codigo like '{codigo}'";
                        }

                        if (!string.IsNullOrEmpty(diseno))
                        {
                            comando += $"and D.diseno like '%{diseno}%'";
                        }
                    }

                    Console.WriteLine(comando);

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    MySqlDataAdapter m_datos = new MySqlDataAdapter(datos);
                    ds = new DataSet();
                    m_datos.Fill(ds);

                    return ds;

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

        public String[] cargarDatosInventarioBodega(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    String[] datosUsuario = new string[10];
                    string comando = $"SELECT S.nombre,  D.idDetalleInventarioBodega, D.codigo, A.cantidad, D.diseno, D.medida, D.pcd, D.pcd2, A.idInventarioBodega, S.idSucursal  FROM InventarioBodega A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleInventarioBodega D on D.idDetalleInventarioBodega = A.idDetalleInventarioBodega inner join usuario U on A.usuarioModificacion = U.idUsuario WHERE idInventarioBodega = {id}";

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    MySqlDataReader reader = datos.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            datosUsuario[0] = reader.GetString(0);
                            datosUsuario[1] = reader.GetString(1);
                            datosUsuario[2] = reader.GetString(2);
                            datosUsuario[3] = reader.GetString(3);
                            datosUsuario[4] = reader.GetString(4);
                            datosUsuario[5] = reader.GetString(5);
                            datosUsuario[6] = reader.GetString(6);
                            datosUsuario[7] = reader.GetString(7);
                            datosUsuario[8] = reader.GetString(8);
                            datosUsuario[9] = reader.GetString(9);

                        }
                        return datosUsuario;
                    }
                    else
                    {
                        return null;
                    }
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

        public bool actualizarInventario(string idEspecifico, string cantidad, string fecha, string idUsuario)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"UPDATE InventarioBodega SET cantidad={cantidad}, fechaModificacion = '{fecha}', usuarioModificacion={idUsuario} WHERE idInventarioBodega ={idEspecifico}", cn);

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
