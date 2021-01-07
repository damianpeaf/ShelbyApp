using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Dominio
{
    public class DReporteLlanta
    {
        public DateTime FechaReporte { get; set; }
        public string nombreSucursalIventario { get; set; }
        public string codigoLlantaInventario { get; set; }
        public List<InventarioLlantaLista> listaLlantas { get; set; }


        public void crearReporteInventario(string idSucursal, string idDetalle, string codigo, bool todas)
        {
            FechaReporte = DateTime.Now;
            Llanta llanta = new Llanta();
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
                codigoLlantaInventario = codigo;
            }
            else
            {
                codigoLlantaInventario = "Todos las Llantass";
            }

            DataTable dt = llanta.buscarLlanta(idSucursal, idDetalle, codigo,  todas).Tables[0];

            listaLlantas = new List<InventarioLlantaLista>();

            foreach (System.Data.DataRow filas in dt.Rows)
            {
                //se podria usar Convert
                var filaLista = new InventarioLlantaLista()
                {
                    sucursal = filas[0].ToString(),
                    idDetalleLlanta = filas[1].ToString(),
                    codigo = filas[2].ToString(),
                    stock = filas[3].ToString(),
                    firma = filas[6].ToString(),
                    ultimaModificacion = filas[7].ToString()

                };

                Console.WriteLine("hola");

                listaLlantas.Add(filaLista);
            }
        }
    }
}
