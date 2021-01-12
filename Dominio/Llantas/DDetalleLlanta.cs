using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DDetalleLlanta
    {
        DetalleLlanta detalle = new DetalleLlanta();

        public DataSet listarTodos()
        {
            return detalle.ListarTodos();
        }

        public DataSet buscarDetalle(string id, string codigo, string medida, string idMarca)
        {
            return detalle.buscarDetalle(id, codigo, medida, idMarca);
        }

        public String[] cargarDatosDetalle(string id)
        {
            return detalle.cargarDatosDetalle(id);

        }

        public bool crearDetalle(string codigo, string medida, string idMarca, string stockInicial)
        {
            return detalle.crearDetalle(codigo, medida, idMarca, stockInicial);
        }

        public bool actualizarDetalle(string id, string codigo, string medida, string idMarca)
        {
            return detalle.actualizarDetalle(id, codigo, medida, idMarca);
        }

        public bool eliminarDetalle(string id)
        {
            return detalle.eliminarDetalle(id);
        }
        public DataTable ComboMarca()
        {
            return detalle.ComboMarca();
        }
    }
}
