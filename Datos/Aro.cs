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

        public DataSet ListarTodos()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = "SELECT S.nombre as 'Sucursal',  D.idDetalleAro as 'ID aro', D.codigo as 'Codigo', A.cantidad as 'Stock',D.diseno, D.medida, D.pcd, D.pcd2, U.nombre as 'Firma', A.fechaModificacion as 'Ultima modificacion'  FROM aro A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleAro D on D.idDetalleAro = A.idDetalleAro inner join usuario U on A.usuarioModificacion = U.idUsuario";

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
                    string comando = $"SELECT S.nombre as 'Sucursal',  D.idDetalleAro as 'ID aro', D.codigo as 'Codigo', A.cantidad as 'Stock',D.diseno, D.medida, D.pcd, D.pcd2, U.nombre as 'Firma', A.fechaModificacion as 'Ultima modificacion'  FROM aro A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleAro D on D.idDetalleAro = A.idDetalleAro inner join usuario U on A.usuarioModificacion = U.idUsuario ";

                    if (todas)
                    {
                        comando += $"where S.idSucursal like '%%'";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $"and D.idDetalleAro like '{idDetalle}'";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $"and D.codigo like '%{codigo}%'";
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
                            comando += $"and D.idDetalleAro like '{idDetalle}'";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $"and D.codigo like '%{codigo}%'";
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

    }
}
