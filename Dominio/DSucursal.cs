using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DSucursal
    {
        Sucursal sucu = new Sucursal();

        public DataSet listarTodos()
        {
            return sucu.ListarTodos();
        }

        public DataSet buscarSucursal(string id, string nombre)
        {
            return sucu.buscarSucursal(id, nombre);
        }

        public String[] cargarDatosSucursal(string id)
        {
            return sucu.cargarDatosSucursal(id);

        }

        public bool crearSucursal(string nombre)
        {
            return sucu.crearSucursal(nombre);
        }

        

        public bool eliminarSucursal(string id)
        {
            return sucu.eliminarSucursal(id);
        }

        

    }
}
