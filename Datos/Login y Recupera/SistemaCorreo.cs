using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    class SistemaCorreo:Correo
    {
        public SistemaCorreo()
        {
            correo = "soportetallerrey@gmail.com";
            password = "soportetaller";
            host = "smtp.gmail.com";
            puerto = 587;
            ssl = true;
            inicioSmtp();
        }
    }
}
