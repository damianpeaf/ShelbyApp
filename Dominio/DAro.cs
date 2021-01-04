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



    }
}
