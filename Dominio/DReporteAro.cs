using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DReporteAro
    {
        public DateTime FechaReporte { get; set; }
        public string nombreSucursalIventario { get; set; }
        public string codigoAroInventario { get; set; }
        public List<InventarioAroLista> listaAros { get; set; }
        

        public void crearReporteInventario(string idSucursal, string idDetalle, string codigo, bool todas)
        {
            FechaReporte = DateTime.Now;
            Aro aro = new Aro();
            Sucursal sucursal = new Sucursal();


            if (todas)
            {
                nombreSucursalIventario = "Todas las sucursales";
            }
            else
            {
                nombreSucursalIventario = sucursal.buscarNombreSucursal(idSucursal);
            }

            if (!string.IsNullOrEmpty(codigo))
            {
                codigoAroInventario = codigo;
            }
            else
            {
                codigoAroInventario = "Todos los aros";
            }

            DataTable dt = aro.buscarAro(idSucursal, idDetalle, codigo, null, todas).Tables[0];

            listaAros = new List<InventarioAroLista>();

            foreach (System.Data.DataRow filas in dt.Rows)
            {
                //se podria usar Convert
                var filaLista = new InventarioAroLista()
                {
                    sucursal = filas[0].ToString(),
                    idDetalleAro = filas[1].ToString(),
                    codigo = filas[2].ToString(),
                    stock = filas[3].ToString(),
                    firma = filas[8].ToString(),
                    ultimaModificacion = filas[9].ToString()

                };

                Console.WriteLine("hola");

                listaAros.Add(filaLista);
            }
        }

    }
}
