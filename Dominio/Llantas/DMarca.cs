using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DMarca
    {
        Marca marc = new Marca();

        public DataSet listarTodos()
        {
            return marc.ListarTodos();
        }

        public DataSet buscarMarca(string id, string nombre)
        {
            return marc.buscarMarca(id, nombre);
        }

        public String[] cargarDatosMarca(string id)
        {
            return marc.cargarDatosMarca(id);

        }

        public bool crearMarca(string nombre)
        {
            return marc.crearMarca(nombre);
        }



        public bool eliminarMarca(string id)
        {
            return marc.eliminarMarca(id);
        }


    }
}
