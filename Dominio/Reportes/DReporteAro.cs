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

        //propiedades generales
        public DateTime FechaReporte { get; set; }
        public string nombreSucursalIventario { get; set; }
        public string codigoAroInventario { get; set; }

        //propiedades inventario
        public List<InventarioAroLista> listaAros { get; set; }

        //propiedades movimientos 
        public List<MovimientoAroLista> listaMovimientos { get; set; }
        public string tipoMovimiento { get; set; }

        public int totalEntradas { get; set; }
        public int totalSalidas { get; set; }

        public int arosEntrantes { get; set; }
        public int arosSalientes { get; set; }

        public string fechaInicio { get; set; }
        public string fechaFinal { get; set; }

        public List<ArosMasEntradas> listaArosMasEntradas { get; set; }
        public List<ArosMasSalidas> listaArosMasSalidas { get; set; }



        //metodo inventario
        public void crearReporteInventario(string idSucursal, string idDetalle, string codigo, bool todas, bool reporteBodegas, bool todaBodegas, string idBodega)
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

            DataTable dt = null;

            if (reporteBodegas)
            {
                dt = aro.buscarBodegaAro(idSucursal, idDetalle, codigo, null, todas,idBodega, todaBodegas).Tables[0];
            }
            else
            {
                dt = aro.buscarAro(idSucursal, idDetalle, codigo, null, todas).Tables[0];

            }

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
                    ultimaModificacion = filas[9].ToString(),
                    precio = filas[11].ToString(),
                    costo = filas[12].ToString()


                };

                Console.WriteLine("hola");

                listaAros.Add(filaLista);
            }
        }

        //metodo movimientos
        public void crearReporteMovimientos(string idSucursal, string idDetalle, string codigo, bool todas, bool rango, string fechaDesde, string fechaHasta, bool ambos, string idTipoMovimiento)
        {
            FechaReporte = DateTime.Now;
            Movimiento aro = new Movimiento();
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


            DataTable dt = aro.buscarMovimiento(idSucursal, idDetalle, codigo, null, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento).Tables[0];

            listaMovimientos = new List<MovimientoAroLista>();
            listaArosMasEntradas = new List<ArosMasEntradas>();
            listaArosMasSalidas = new List<ArosMasSalidas>();

            int totEntradas = 0;
            int totSalidas = 0;

            int cantidadEntrante = 0;
            int cantidadSaliente = 0;


            foreach (System.Data.DataRow filas in dt.Rows)
            {
                //se podria usar Convert
                var filaLista = new MovimientoAroLista()
                {
                    sucursal = filas[0].ToString(),
                    idDetalleAro = filas[1].ToString(),
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
                else if(filas[4].ToString() == "Entrada")
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

            arosEntrantes = cantidadEntrante;
            arosSalientes = cantidadSaliente;


            Console.WriteLine(totalEntradas.ToString());
        }

    }
}
