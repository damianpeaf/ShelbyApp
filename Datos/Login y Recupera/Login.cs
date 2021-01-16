using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Comun;

namespace Datos
{
    public class Login
    {
        MySqlConnection cn;
        public bool loginpagina(string user, string pass)
        {

            using (cn = new Conexion().IniciarConexion())
            {

                try
                {

                    Console.WriteLine("HSADL" + user);
                    Console.WriteLine("HSADL" + pass);

                    MySqlCommand comando = new MySqlCommand($"select * from usuario where correo='{user}' and contrasena='{pass}' and idEstado=1", cn);
                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            info_usuario.idUsuario = reader.GetString(0);
                            info_usuario.nombre = reader.GetString(1);
                            info_usuario.email = reader.GetString(2);

                            if (!reader.IsDBNull(4))
                            {
                                info_usuario.idSucursal = reader.GetString(4);

                            }
                            else
                            {
                                info_usuario.idSucursal = null; 
                            }

                            info_usuario.idRol = reader.GetString(5);

                        }

                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR EN LA CONEXION A LA BD: " + ex);
                    return false;
                }
            }
        }



        public string recuperarcontra(string correo)
        {
            using (cn = new Conexion().IniciarConexion())

            {
                MySqlCommand comando = new MySqlCommand($"select * from usuario where correo ='{correo}'", cn);
                MySqlDataReader datos = comando.ExecuteReader();

                if (datos.HasRows)
                {
                    string correou = "";
                    string contrau = "";
                    string nombreu = "";


                    if (datos.Read())
                    {
                        correou = datos.GetString(2);
                        contrau = datos.GetString(3);
                        nombreu = datos.GetString(1);

                        var servicio = new SistemaCorreo();

                        servicio.EnvioCorreo("Recuperacion de Cuenta | Aros y Llantas Reynoso", $"Estimad@ {nombreu}, hemos procesado su solicitud.  Su contraseña es: {contrau}", correou);
                    }
                    return $"Hemos enviado un mensaje al correo: {correo}";
                }
                else
                {
                    return "NO SE PUDO REALIZAR DICHA SOLICITUD";
                }
            }
        }

    }
}
