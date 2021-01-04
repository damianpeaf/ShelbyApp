using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DetalleAro
    {

        MySqlConnection cn;
        DataSet ds;

        public DataSet ListarTodos()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = "SELECT * FROM detalleAro";

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

        public DataSet buscarDetalle(string id, string codigo, string medida, string diseno)
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT * FROM detalleAro where idDetalleAro like '{id}'";

                    if (!string.IsNullOrEmpty(codigo))
                    {
                        comando += $"or codigo like '%{codigo}%'";
                    }

                    if (!string.IsNullOrEmpty(medida))
                    {
                        comando += $"or medida like '%{medida}%'";
                    }

                    if (!string.IsNullOrEmpty(diseno))
                    {
                        comando += $"or diseno like '%{diseno}%'";
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

        public String[] cargarDatosDetalle(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    String[] datosDetalle = new string[6];
                    string comando = $"SELECT * FROM detalleAro where idDetalleAro = {id}";

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    MySqlDataReader reader = datos.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            datosDetalle[0] = reader.GetString(0);
                            datosDetalle[1] = reader.GetString(1);
                            datosDetalle[2] = reader.GetString(2);
                            datosDetalle[3] = reader.GetString(3);
                            datosDetalle[4] = reader.GetString(4);
                            datosDetalle[5] = reader.GetString(5);


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

        public bool crearDetalle(string codigo, string medida, string pcd, string pcd2, string diseno)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"INSERT INTO detalleAro VALUES(null,'{codigo}' , '{medida}', '{pcd}', '{pcd2}', '{diseno}')", cn);
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

        public bool actualizarDetalle(string id, string codigo, string medida, string pcd, string pcd2, string diseno)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"UPDATE detalleAro SET codigo='{codigo}', medida='{medida}', pcd='{pcd}', pcd2='{pcd2}', diseno='{diseno}' WHERE idDetalleAro ={id}", cn);

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

        public bool eliminarDetalle(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"DELETE FROM detalleAro WHERE idDetalleAro ={id}", cn);

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
