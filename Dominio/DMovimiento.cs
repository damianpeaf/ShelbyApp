using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DMovimiento
    {
        Movimiento movimiento =  new Movimiento();

        public bool crearMovimientoAro(string idDetalleAro, string idSucursal, string cantidad, string fecha, string idTipoMovimiento)
        {
            return movimiento.crearMovimientoAro(idDetalleAro, idSucursal, cantidad, fecha, idTipoMovimiento);
        }
        public bool crearMovimientoLlanta(string idDetalleLlanta, string idSucursal, string cantidad, string fecha, string idTipoMovimiento)
        {
            return movimiento.crearMovimientoLlanta(idDetalleLlanta, idSucursal, cantidad, fecha, idTipoMovimiento);
        }

        public DataSet buscarMovimiento(string idSucursal, string idDetalle, string codigo, string diseno, bool todas, bool rango, string fechaDesde, string fechaHasta, bool ambos, string idTipoMovimiento)
        {
            return movimiento.buscarMovimiento(idSucursal, idDetalle, codigo, diseno, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento);
        }
        public DataSet buscarMovimiento1(string idSucursal, string idDetalle, string codigo, bool todas, bool rango, string fechaDesde, string fechaHasta, bool ambos, string idTipoMovimiento)
        {
            return movimiento.buscarMovimiento1(idSucursal, idDetalle, codigo, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento);
        }

        public DataSet listarTodos()
        {
            return movimiento.ListarTodos();
        }
        public DataSet listarTodos1()
        {
            return movimiento.ListarTodos1();
        }
    }
}
