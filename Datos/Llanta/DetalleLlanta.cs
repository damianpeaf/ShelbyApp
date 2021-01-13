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
    public class DetalleLlanta
    {

        MySqlConnection cn;
        DataSet ds;

        public DataSet ListarTodos()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = "SELECT D.idDetalleLlanta, D.codigo, D.medida, M.nombre FROM detalleLlanta D inner join marca M on D.idMarca = M.idMarca";

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

        public DataSet buscarDetalle(string id, string codigo, string medida, string idMarca)
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT D.idDetalleLlanta, D.codigo, D.medida, M.nombre FROM detalleLlanta D inner join marca M on D.idMarca = M.idMarca where idDetalleLlanta like '{id}'";

                    if (!string.IsNullOrEmpty(codigo))
                    {
                        comando += $"or D.codigo like '%{codigo}%'";
                    }

                    if (!string.IsNullOrEmpty(medida))
                    {
                        comando += $"or D.medida like '%{medida}%'";
                    }

                    if (!string.IsNullOrEmpty(idMarca))
                    {
                        comando += $"or D.idMarca like '%{idMarca}%'";
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
                    string comando = $"SELECT D.idDetalleLlanta, D.codigo, D.medida, M.nombre FROM detalleLlanta D inner join marca M on D.idMarca = M.idMarca where idDetalleLlanta = {id}";

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

        public bool crearDetalle(string codigo, string medida, string idMarca,string costo, string precio, string stockInicial)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"INSERT INTO detalleLlanta VALUES(null,'{codigo}' , '{medida}', '{idMarca}','{costo}','{precio}' )", cn);
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

                            Llanta lla = new Llanta();

                            lla.crearDisponibilidadDesdeLlanta(ultimaId, idUsuario, stockInicial);
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

        public bool actualizarDetalle(string id, string codigo, string medida, string idMarca, string costo, string precio)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"UPDATE detalleLlanta SET codigo='{codigo}', medida='{medida}', IdMarca='{idMarca}', costo='{costo}', precio='{precio}' WHERE idDetalleLlanta ={id}", cn);

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
                    //inventario llanta
                    MySqlCommand comando1 = new MySqlCommand($"DELETE FROM llanta WHERE idDetalleLlanta ={id}", cn);
                    comando1.ExecuteNonQuery();

                    //inventario movimiento
                    MySqlCommand comando3 = new MySqlCommand($"DELETE FROM movimiento WHERE idDetalleLlanta ={id}", cn);
                    comando3.ExecuteNonQuery();

                    MySqlCommand comandoFinal = new MySqlCommand($"DELETE FROM detalleLlanta WHERE idDetalleLlanta ={id}", cn);

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
        public DataTable ComboMarca()
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string sql = "select idMarca, nombre FROM marca";
                    MySqlCommand comando = new MySqlCommand(sql, cn);

                    MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    datos.Fill(dt);

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
