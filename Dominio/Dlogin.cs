using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class Dlogin
    {
        Login login = new Login();
        public bool loginpa(string user, string pass)
        {
            return login.loginpagina(user, pass);
        }
        public string recuperarcontra(string correo)
        {
            return login.recuperarcontra(correo);
        }
    }
}
