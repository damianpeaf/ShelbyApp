using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Aro
    {
        MySqlConnection cn;
        DataSet ds;

        public bool crearDisponibilidadDesdeAro(string idDetalle, string idUsuario, string stockInicial)
        {
            try
            {
                string cantidad = stockInicial;

                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand cmd1 = new MySqlCommand($"SELECT idSucursal FROM sucursal", cn);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();

                    if (reader1.HasRows)
                    {

                        while (reader1.Read())
                        {
                            cn = new Conexion().IniciarConexion();

                            //stock inicial por cada tienda
                            

                            string idSucursal = reader1.GetString(0);
                            string sql = $"INSERT INTO aro (idAro, idDetalleAro, cantidad, usuarioModificacion, idSucursal) VALUES (null, {idDetalle}, {cantidad}, {idUsuario}, {idSucursal})";
                            MySqlCommand cmd = new MySqlCommand(sql, cn);
                            cmd.ExecuteNonQuery();

                            Movimiento movimiento = new Movimiento();
                            
                            DateTime dateValue = DateTime.Now;
                            string fecha = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

                            movimiento.crearMovimientoAro(idDetalle, idSucursal, cantidad, fecha, "1");

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

                            string cantidad = "0";

                            string idDetalle = reader1.GetString(0);
                            string sql = $"INSERT INTO aro (idAro, idDetalleAro, cantidad, usuarioModificacion, idSucursal) VALUES (null, {idDetalle}, {cantidad}, {idUsuario}, {idSucursal})";
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

        public DataSet ListarTodos()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = "SELECT S.nombre as 'Sucursal',  D.idDetalleAro as 'ID aro', D.codigo as 'Codigo', A.cantidad as 'Stock',D.diseno, D.medida, D.pcd, D.pcd2, U.nombre as 'Firma',DATE_FORMAT(A.fechaModificacion, '%d/%m/%Y %H:%i')  as 'Ultima modificacion', A.idAro as 'ID específica', D.precio, D.costo  FROM aro A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleAro D on D.idDetalleAro = A.idDetalleAro inner join usuario U on A.usuarioModificacion = U.idUsuario where idBodega is null ";

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

        public DataSet buscarAro(string idSucursal, string idDetalle, string codigo, string diseno, bool todas)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT S.nombre as 'Sucursal',  D.idDetalleAro as 'ID aro', D.codigo as 'Codigo', A.cantidad as 'Stock',D.diseno, D.medida, D.pcd, D.pcd2, U.nombre as 'Firma', DATE_FORMAT(A.fechaModificacion, '%d/%m/%Y %H:%i') as 'Ultima modificacion', A.idAro as 'ID específica', D.precio, D.costo  FROM aro A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleAro D on D.idDetalleAro = A.idDetalleAro inner join usuario U on A.usuarioModificacion = U.idUsuario ";

                    if (todas)
                    {
                        comando += $" where S.idSucursal like '%%'  and idBodega is null ";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $" and D.idDetalleAro like '{idDetalle}' ";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $" and D.codigo like '{codigo}' ";
                        }

                        if (!string.IsNullOrEmpty(diseno))
                        {
                            comando += $" and D.diseno like '%{diseno}%' ";
                        }
                    }
                    else
                    {
                        comando += $" where S.idSucursal like '{idSucursal}' and idBodega is null ";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $" and D.idDetalleAro like '{idDetalle}' ";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $" and D.codigo like '{codigo}' ";
                        }

                        if (!string.IsNullOrEmpty(diseno))
                        {
                            comando += $" and D.diseno like '%{diseno}%' ";
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


        public String idSucursalAsociada(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    String datosUsuario = "";
                    string comando = $"SELECT idSucursal FROM aro WHERE idAro = {id}";

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    MySqlDataReader reader = datos.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            datosUsuario = reader.GetString(0);


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

        public DataSet buscarBodegaAro(string idSucursal, string idDetalle, string codigo, string diseno, bool todas, string idBodega, bool todasBodegas)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT CONCAT('Sucursal: ', S.nombre, ' Bodega: ', B.nombre) as 'Info Bodega',  D.idDetalleAro as 'ID aro', D.codigo as 'Codigo', A.cantidad as 'Stock',D.diseno, D.medida, D.pcd, D.pcd2, U.nombre as 'Firma', DATE_FORMAT(A.fechaModificacion, '%d/%m/%Y %H:%i') as 'Ultima modificacion', A.idAro as 'ID específica', D.precio, D.costo  FROM aro A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleAro D on D.idDetalleAro = A.idDetalleAro inner join usuario U on A.usuarioModificacion = U.idUsuario inner join bodega B on B.idBodega = A.idBodega ";

                    if (todas)
                    {
                        comando += $" where S.idSucursal like '%%'";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $" and D.idDetalleAro like '{idDetalle}'";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $" and D.codigo like '{codigo}'";
                        }

                        if (!string.IsNullOrEmpty(diseno))
                        {
                            comando += $" and D.diseno like '%{diseno}%'";
                        }

                        if (todasBodegas)
                        {
                            comando += $" and B.idBodega like '%%'";
                        }
                        else
                        {
                            comando += $" and B.idBodega like '{idBodega}'";

                        }
                    }
                    else
                    {
                        comando += $" where S.idSucursal like '{idSucursal}' ";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $" and D.idDetalleAro like '{idDetalle}'";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $" and D.codigo like '{codigo}'";
                        }

                        if (!string.IsNullOrEmpty(diseno))
                        {
                            comando += $" and D.diseno like '%{diseno}%'";
                        }

                        if (todasBodegas)
                        {
                            comando += $" and B.idBodega like '%%'";
                        }
                        else
                        {
                            comando += $" and B.idBodega like '{idBodega}'";

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

        public String[] cargarDatosAro(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    String[] datosUsuario = new string[10];
                    string comando = $"SELECT S.nombre,  D.idDetalleAro, D.codigo, A.cantidad, D.diseno, D.medida, D.pcd, D.pcd2, A.idAro, S.idSucursal  FROM aro A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleAro D on D.idDetalleAro = A.idDetalleAro inner join usuario U on A.usuarioModificacion = U.idUsuario WHERE idAro = {id}";

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
                    MySqlCommand comando = new MySqlCommand($"UPDATE aro SET cantidad={cantidad}, fechaModificacion = '{fecha}', usuarioModificacion={idUsuario} WHERE idAro ={idEspecifico}", cn);

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
