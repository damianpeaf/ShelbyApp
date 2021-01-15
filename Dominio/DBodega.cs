using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DBodega
    {
        Bodega bode = new Bodega();

        public DataSet listarTodos()
        {
            return bode.ListarTodos();
        }

        public DataSet buscarBodega(string id, string nombre, string idSucursal, bool todas)
        {
            return bode.buscarBodega(id, nombre, idSucursal, todas);
        }

        public String[] cargarDatosBodega(string id)
        {
            return bode.cargarDatosBodega(id);

        }

        public bool crearBodega(string nombre, string idSucursal)
        {
            return bode.crearBodega(nombre, idSucursal);
        }



        public bool eliminarBodega(string id)
        {
            return bode.eliminarBodega(id);
        }
        public bool actualizarBodega(string id, string nombre, string idSucursal)
        {
            return bode.actualizarBodega(id, nombre, idSucursal);
        }

        public DataTable CrearCombo(string idSucursal)
        {
            return bode.CrearCombo(idSucursal);
        }
    }
}
