using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DRol
    {

        Rol rol = new Rol();

        public DataTable CrearCombo()
        {
            return rol.CrearCombo();
        }


    }
}
