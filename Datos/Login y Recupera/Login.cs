﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Login
    {
        MySqlConnection cn;
        public bool loginpagina(string user, string pass)
        {


            using (cn = new Conexion().IniciarConexion())
            using (var command = new MySqlCommand())
            {
                command.Connection = cn;
                command.CommandText = "select *from usuario where correo=@user and contrasena=@pass";
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", pass);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      

                    }
                    return true;
                }
                else
                    return false;
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
