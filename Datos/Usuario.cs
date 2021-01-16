using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {

        MySqlConnection cn;
        DataSet ds;

        public DataSet ListarTodos()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = "SELECT U.idUsuario, U.nombre, U.correo, R.nombre as 'Rol', S.nombre as 'Sucursal asociada', E.nombre  as 'Estado' FROM usuario U left join sucursal S on U.idSucursal = S.idSucursal inner join estado E on E.idEstado = U.idEstado inner join rol R on R.idRol = U.idRol  ";

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

        public DataSet buscarUsuario(string id, string nombre, string correo)
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string comando = $"SELECT U.idUsuario, U.nombre, U.correo, R.nombre as 'Rol', S.nombre as 'Sucursal asociada', E.nombre  as 'Estado' FROM usuario U left join sucursal S on U.idSucursal = S.idSucursal inner join estado E on E.idEstado = U.idEstado inner join rol R on R.idRol = U.idRol where idUsuario like '{id}'";

                    if (!string.IsNullOrEmpty(nombre))
                    {
                        comando += $"or nombre like '%{nombre}%'";
                    }

                    if (!string.IsNullOrEmpty(correo))
                    {
                        comando += $"or correo like '%{correo}%'";
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

        public String[] cargarDatosUsuario(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    String[] datosUsuario = new string[4];
                    string comando = $"SELECT idUsuario, nombre, correo, contrasena FROM usuario where idUsuario = {id}";

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    Console.WriteLine(comando);

                    MySqlDataReader reader = datos.ExecuteReader();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {

                            datosUsuario[0] = reader.GetString(0);
                            datosUsuario[1] = reader.GetString(1);
                            datosUsuario[2] = reader.GetString(2);
                            datosUsuario[3] = reader.GetString(3);


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

        public bool crearUsuario(string nombre, string correo, string contrasena, string idSucursal, string idRol)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"INSERT INTO usuario VALUES(null,'{nombre}' , '{correo}', '{contrasena}', {idSucursal}, {idRol}, 1)", cn);
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

        public bool actualizarUsuario(string id, string nombre, string correo)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"UPDATE usuario SET nombre='{nombre}', correo='{correo}' WHERE idUsuario ={id}", cn);

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

        public bool eliminarUsuario(string id)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"UPDATE usuario SET idEstado = 2 WHERE idUsuario ={id}", cn);

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

        public bool actualizarDatosUsuario(string id, string nombre, string correo, string contrasena)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {

                    bool modificado = false;
                    if (!string.IsNullOrEmpty(nombre) || !string.IsNullOrEmpty(correo) || !string.IsNullOrEmpty(contrasena))
                    {

                        if (!string.IsNullOrEmpty(nombre))
                        {

                            MySqlCommand comando = new MySqlCommand($"UPDATE usuario SET nombre='{nombre}' WHERE idUsuario ={id}", cn);
                            if (comando.ExecuteNonQuery() > 0)
                            {
                                modificado =  true;
                            }
                        }

                        if (!string.IsNullOrEmpty(correo))
                        {

                            MySqlCommand comando = new MySqlCommand($"UPDATE usuario SET correo='{correo}' WHERE idUsuario ={id}", cn);
                            if (comando.ExecuteNonQuery() > 0)
                            {
                                modificado = true;
                            }
                        }

                        if (!string.IsNullOrEmpty(contrasena))
                        {

                            MySqlCommand comando = new MySqlCommand($"UPDATE usuario SET contrasena='{contrasena}' WHERE idUsuario ={id}", cn);
                            if (comando.ExecuteNonQuery() > 0)
                            {
                                modificado = true;
                            }
                        }

                        if (modificado)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

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
