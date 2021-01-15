using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;

namespace Datos
{
    public class Sucursal
    {
        MySqlConnection cn;
        DataSet ds;

        public DataSet ListarTodos()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = "SELECT idSucursal, nombre FROM sucursal";

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

        public string buscarNombreSucursal(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT nombre FROM sucursal where idSucursal like '{id}'";

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    MySqlDataReader reader = datos.ExecuteReader();
                    string nombreSucursal ="";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            nombreSucursal = reader.GetString(0);
                        }
                    }

                    return nombreSucursal;


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

        public DataSet buscarSucursal(string id, string nombre)
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT idSucursal, nombre FROM sucursal where idSucursal like '{id}'";

                    if (!string.IsNullOrEmpty(nombre))
                    {
                        comando += $"or nombre like '%{nombre}%'";
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

        public String[] cargarDatosSucursal(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    String[] datosSucursal = new string[4];
                    string comando = $"SELECT idSucursal, nombre FROM sucursal where idSucursal = {id}";

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    MySqlDataReader reader = datos.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            datosSucursal[0] = reader.GetString(0);
                            datosSucursal[1] = reader.GetString(1);
                      


                        }
                        return datosSucursal;
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

        public bool crearSucursal(string nombre)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"INSERT INTO sucursal VALUES(null,'{nombre}' )", cn);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        //parte del inventario
                        MySqlCommand cmd = new MySqlCommand("SELECT LAST_INSERT_ID() as ultimaId", cn);

                        string ultimaId = "";
                        string idUsuario = info_usuario.idUsuario;

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                ultimaId = reader.GetString(0);
                            }

                            Aro aro = new Aro();

                            aro.crearDisponibilidadDesdeSucursal(ultimaId, idUsuario);

                            Llanta lla = new Llanta();

                            lla.crearDisponibilidadDesdeSucursal(ultimaId, idUsuario);
                        }
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
               
        public bool eliminarSucursal(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    //inventario llanta
                    MySqlCommand comando1 = new MySqlCommand($"DELETE FROM llanta WHERE idSucursal ={id}", cn);
                    comando1.ExecuteNonQuery();

                    //inventario aro
                    MySqlCommand comando2 = new MySqlCommand($"DELETE FROM aro WHERE idSucursal ={id}", cn);
                    comando2.ExecuteNonQuery();

                    //inventario movimiento
                    MySqlCommand comando3 = new MySqlCommand($"DELETE FROM movimiento WHERE idSucursal ={id}", cn);
                    comando3.ExecuteNonQuery();

                    MySqlCommand comandoFinal = new MySqlCommand($"DELETE FROM sucursal WHERE idSucursal ={id}", cn);

                    if (comandoFinal.ExecuteNonQuery() > 0)
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

        public DataTable CrearCombo()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string sql = "SELECT idSucursal, nombre FROM sucursal";

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

        public bool actualizarSucursal(string id, string nombre)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"UPDATE sucursal SET nombre='{nombre}' WHERE idSucursal ={id}", cn);

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
