using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class Bodega
    {
        MySqlConnection cn;
        DataSet ds;

        public DataSet ListarTodos()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = "SELECT B.idBodega, B.nombre, S.nombre FROM bodega B inner join sucursal S on B.idSucursal = S.idSucursal";

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

        public DataSet buscarBodega(string id, string nombre, string idSucursal, bool todas)
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT B.idBodega, B.nombre, S.nombre FROM bodega B inner join sucursal S on B.idSucursal = S.idSucursal ";

                    if (todas)
                    {

                        comando += $"where S.idSucursal like '%%'";

                        if (!string.IsNullOrEmpty(id))
                        {
                            comando += $"and B.idBodega like '{id}'";
                        }

                        if (!string.IsNullOrEmpty(nombre))
                        {
                            comando += $"and B.codigo like '{nombre}'";
                        }
                    }

                    else
                        {
                            comando += $"where S.idSucursal like '{idSucursal}'";

                            if (!string.IsNullOrEmpty(id))
                            {
                                comando += $"and B.idDetalleAro like '{id}'";
                            }

                            if (!string.IsNullOrEmpty(nombre))
                            {
                                comando += $"and B.nombre like '{nombre}'";
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
        public DataSet buscarAro(string idSucursal, string idDetalle, string codigo, string diseno, bool todas)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT S.nombre as 'Sucursal',  D.idDetalleAro as 'ID aro', D.codigo as 'Codigo', A.cantidad as 'Stock',D.diseno, D.medida, D.pcd, D.pcd2, U.nombre as 'Firma', DATE_FORMAT(A.fechaModificacion, '%d/%m/%Y %H:%i') as 'Ultima modificacion', A.idAro as 'ID específica', D.precio, D.costo  FROM aro A inner join sucursal S on A.idSucursal = S.idSucursal inner join detalleAro D on D.idDetalleAro = A.idDetalleAro inner join usuario U on A.usuarioModificacion = U.idUsuario ";

                    if (todas)
                    {
                        comando += $"where S.idSucursal like '%%'";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $"and D.idDetalleAro like '{idDetalle}'";
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
                            comando += $"and D.idDetalleAro like '{idDetalle}'";
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
        public String[] cargarDatosBodega(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    String[] datosDetalle = new string[3];
                    string comando = $"SELECT B.idBodega, B.nombre, S.nombre FROM bodega B inner join sucursal S on B.idSucursal = S.idSucursal where idBodega = {id}";

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    MySqlDataReader reader = datos.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            datosDetalle[0] = reader.GetString(0);
                            datosDetalle[1] = reader.GetString(1);
                            datosDetalle[2] = reader.GetString(2);
                   

                        }
                        return datosDetalle;
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

        public bool crearBodega(string nombre, string idSucursal)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"INSERT INTO bodega VALUES(null,'{nombre}','{idSucursal}' )", cn);
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



        public bool eliminarBodega(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"DELETE FROM bodega WHERE idBodega ={id}", cn);

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

        public bool actualizarBodega(string id,string nombre, string idSucursal)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"UPDATE bodega SET nombre='{nombre}', idSucursal='{idSucursal}' WHERE idBodega ={id}", cn);

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
