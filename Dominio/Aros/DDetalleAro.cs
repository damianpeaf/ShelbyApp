using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DDetalleAro
    {

        DetalleAro detalle = new DetalleAro();

        public DataSet listarTodos()
        {
            return detalle.ListarTodos();
        }

        public DataSet buscarDetalle(string id, string codigo, string medida, string diseno)
        {
            return detalle.buscarDetalle(id, codigo, medida, diseno);
        }

        public String[] cargarDatosDetalle(string id)
        {
            return detalle.cargarDatosDetalle(id);

        }

        public bool crearDetalle(string codigo, string medida, string pcd, string pcd2, string diseno)
        {
            return detalle.crearDetalle(codigo, medida, pcd, pcd2, diseno);
        }

        public bool actualizarDetalle(string id, string codigo, string medida, string pcd, string pcd2, string diseno)
        {
            return detalle.actualizarDetalle(id, codigo, medida, pcd, pcd2, diseno);
        }

        public bool eliminarDetalle(string id)
        {
            return detalle.eliminarDetalle(id);
        }

    }
}
