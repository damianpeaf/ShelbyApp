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
                    String[] datosDetalle = new string[8];
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
                            datosDetalle[6] = reader.GetString(6);
                            datosDetalle[7] = reader.GetString(7);


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

        public bool crearDetalle(string codigo, string medida, string pcd, string pcd2, string diseno, string costo, string precio, string stockInicial)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"INSERT INTO detalleAro VALUES(null,'{codigo}' , '{medida}', '{pcd}', '{pcd2}', '{diseno}','{costo}','{precio}' )", cn);
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

                            aro.crearDisponibilidadDesdeAro(ultimaId, idUsuario, stockInicial);
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

        public bool actualizarDetalle(string id, string codigo, string medida, string pcd, string pcd2, string diseno, string costo, string precio )
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"UPDATE detalleAro SET codigo='{codigo}', medida='{medida}', pcd='{pcd}', pcd2='{pcd2}', diseno='{diseno}', costo='{costo}', precio='{precio}' WHERE idDetalleAro ={id}", cn);

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
                    MySqlCommand comando1 = new MySqlCommand($"DELETE FROM aro WHERE idDetalleAro ={id}", cn);
                    comando1.ExecuteNonQuery();

                    //inventario movimiento
                    MySqlCommand comando3 = new MySqlCommand($"DELETE FROM movimiento WHERE idDetalleAro ={id}", cn);
                    comando3.ExecuteNonQuery();

                    MySqlCommand comandoFinal = new MySqlCommand($"DELETE FROM detalleAro WHERE idDetalleAro ={id}", cn);

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
    }
}
