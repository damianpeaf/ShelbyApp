using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DUsuario
    {

        Usuario user = new Usuario();

        public DataSet listarTodos()
        {
            return user.ListarTodos();
        }

        public DataSet buscarUsuario(string id, string nombre, string correo)
        {
            return user.buscarUsuario(id, nombre, correo);
        }

        public String[] cargarDatosUsuario(string id)
        {
            return user.cargarDatosUsuario(id);

        }

        public bool crearUsuario(string nombre, string correo, string contrasena)
        {
            return user.crearUsuario(nombre, correo, contrasena);
        }

        public bool actualizarUsuario(string id, string nombre, string correo)
        {
            return user.actualizarUsuario(id, nombre, correo);
        }

        public bool eliminarUsuario(string id)
        {
            return user.eliminarUsuario(id);
        }


    }
}
