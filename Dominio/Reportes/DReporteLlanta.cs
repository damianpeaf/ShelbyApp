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

        //propiedades movimientos 
        public List<MovimientoLlantaLista> listaMovimientos { get; set; }
        public string tipoMovimiento { get; set; }

        public int totalEntradas { get; set; }
        public int totalSalidas { get; set; }

        public int llantasEntrantes { get; set; }
        public int llantasSalientes { get; set; }

        public string fechaInicio { get; set; }
        public string fechaFinal { get; set; }

        public List<ArosMasEntradas> listaArosMasEntradas { get; set; }
        public List<ArosMasSalidas> listaArosMasSalidas { get; set; }


        public void crearReporteInventario(string idSucursal, string idDetalle, string codigo, bool todas, bool costoVisible)
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
            string costoDato = null;

            foreach (System.Data.DataRow filas in dt.Rows)
            {

                if (costoVisible)
                {
                    costoDato = filas[9].ToString();
                }
                else if(!costoVisible)
                {
                    costoDato = null;
                }

                //se podria usar Convert
                var filaLista = new InventarioLlantaLista()
                {
                    sucursal = filas[0].ToString(),
                    idDetalleLlanta = filas[1].ToString(),
                    codigo = filas[2].ToString(),
                    stock = filas[3].ToString(),
                    firma = filas[6].ToString(),
                    ultimaModificacion = filas[7].ToString(),
                    precio = filas[10].ToString(),
                    costo = costoDato

                };

                listaLlantas.Add(filaLista);
            }
        }

        //metodo movimientos
        public void crearReporteMovimientos(string idSucursal, string idDetalle, string codigo, bool todas, bool rango, string fechaDesde, string fechaHasta, bool ambos, string idTipoMovimiento)
        {
            FechaReporte = DateTime.Now;
            Movimiento llanta = new Movimiento();
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
                codigoLlantaInventario = "Todas las llantas";
            }

            if (ambos)
            {
                tipoMovimiento = "Salidas y entradas";
            }
            else
            {
                if (int.Parse(idTipoMovimiento) == 0)
                {
                    tipoMovimiento = "Salidas";
                }
                else if (int.Parse(idTipoMovimiento) == 1)
                {
                    tipoMovimiento = "Entradas";
                }
            }

            if (rango)
            {
                fechaInicio = fechaDesde;
                fechaFinal = fechaHasta;

            }
            else
            {
                fechaInicio = "el principio";
                fechaFinal = "la última fecha registrada";
            }


            DataTable dt = llanta.buscarMovimiento1(idSucursal, idDetalle, codigo,  todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento).Tables[0];

            listaMovimientos = new List<MovimientoLlantaLista>();
            listaArosMasEntradas = new List<ArosMasEntradas>();
            listaArosMasSalidas = new List<ArosMasSalidas>();

            int totEntradas = 0;
            int totSalidas = 0;

            int cantidadEntrante = 0;
            int cantidadSaliente = 0;


            foreach (System.Data.DataRow filas in dt.Rows)
            {
                //se podria usar Convert
                var filaLista = new MovimientoLlantaLista()
                {
                    sucursal = filas[0].ToString(),
                    idDetalleLlanta = filas[1].ToString(),
                    codigo = filas[2].ToString(),
                    cantidad = filas[3].ToString(),
                    tipo = filas[4].ToString(),
                    fecha = filas[5].ToString()

                };

                if (filas[4].ToString() == "Salida")
                {
                    totSalidas++;
                    cantidadSaliente += Convert.ToInt32(filas[3]);

                    var filaSalida = new ArosMasSalidas()
                    {
                        cantidadSaliente = Convert.ToInt32(filas[3]),
                        codigoSaliente = filas[2].ToString()
                    };

                    listaArosMasSalidas.Add(filaSalida);


                }
                else if (filas[4].ToString() == "Entrada")
                {
                    totEntradas++;
                    cantidadEntrante += Convert.ToInt32(filas[3]);

                    var filaEntrada = new ArosMasEntradas()
                    {
                        cantidadEntrante = Convert.ToInt32(filas[3]),
                        codigoEntrante = filas[2].ToString()
                    };

                    listaArosMasEntradas.Add(filaEntrada);
                }

                listaMovimientos.Add(filaLista);
            }

            totalEntradas = totEntradas;
            totalSalidas = totSalidas;

            llantasEntrantes = cantidadEntrante;
            llantasSalientes = cantidadSaliente;


            Console.WriteLine(totalEntradas.ToString());
        }

    }
}
