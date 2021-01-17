using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DLlanta
    {
       Llanta llanta = new Llanta();

        public DataSet listarTodos()
        {
            return llanta.ListarTodos();
        }

        public DataSet buscarLlanta(string idSucursal, string idDetalle, string codigo , bool todas)
        {
            return llanta.buscarLlanta(idSucursal, idDetalle, codigo,  todas);
        }

        public String[] cargarDatosLlanta(string id)
        {
            return llanta.cargarDatosLlanta(id);
        }

        public bool actualizarInventario(string idEspecifico, string cantidad, string fecha, string idUsuario)
        {
            return llanta.actualizarInventario(idEspecifico, cantidad, fecha, idUsuario);
        }
        public DataSet buscarBodegaLlanta(string idSucursal, string idDetalle, string codigo, bool todas, string idBodega, bool todasBodegas)
        {
            return llanta.buscarBodegaLlanta(idSucursal, idDetalle, codigo, todas, idBodega, todasBodegas);
        }

        public String idSucursalAsociada(string id)
        {
            return llanta.idSucursalAsociada(id);
        }
    }
}
