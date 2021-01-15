using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DAro
    {

        Aro aro = new Aro();

        public DataSet listarTodos()
        {
            return aro.ListarTodos();
        }

        public DataSet buscarAro(string idSucursal, string idDetalle, string codigo, string diseno, bool todas)
        {
            return aro.buscarAro(idSucursal, idDetalle, codigo, diseno, todas);
        }

        public DataSet buscarBodegaAro(string idSucursal, string idDetalle, string codigo, string diseno, bool todas, string idBodega, bool todasBodegas)
        {
            return aro.buscarBodegaAro(idSucursal, idDetalle, codigo, diseno, todas, idBodega, todasBodegas);
        }

        public String[] cargarDatosAro(string id)
        {
            return aro.cargarDatosAro(id);
        }

        public bool actualizarInventario(string idEspecifico, string cantidad, string fecha, string idUsuario)
        {
            return aro.actualizarInventario(idEspecifico, cantidad, fecha, idUsuario);
        }
    }
}
