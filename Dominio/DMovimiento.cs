using System;
using System.Collections.Generic;
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
    }
}
