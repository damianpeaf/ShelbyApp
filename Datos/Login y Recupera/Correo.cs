using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Datos
{
    public abstract class Correo
    {
        private SmtpClient usuario;
        public static string password { get; set; }
        public static string correo { get; set; }
        public static string host { get; set; }
        public static int puerto { get; set; }
        public static bool ssl { get; set; }

        protected void inicioSmtp()
        {
            try
            {
                usuario = new SmtpClient();
                usuario.Credentials = new NetworkCredential(correo, password);
                usuario.Host = host;
                usuario.Port = puerto;
                usuario.EnableSsl = ssl;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
            }
        }

        public void EnvioCorreo(string asunto, string cuerpo, string correos)
        {
            var mensaje = new MailMessage();
            try
            {
                mensaje.From = new MailAddress(correo);
                mensaje.To.Add(new MailAddress(correos));


                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;
                mensaje.Priority = MailPriority.Normal;
                usuario.Send(mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                mensaje.Dispose();
                usuario.Dispose();
            }
        }
    }
}
