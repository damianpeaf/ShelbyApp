using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Movimiento
    {
        MySqlConnection cn;
        DataSet ds;

        public bool crearMovimientoAro(string idDetalleAro, string idSucursal, string cantidad, string fecha, string idTipoMovimiento)
        {
                try
                {
                    using (cn = new Conexion().IniciarConexion())
                    {
                        MySqlCommand comando = new MySqlCommand($"INSERT INTO movimiento VALUES(null,{idDetalleAro},null, {idSucursal}, {cantidad}, '{fecha}', {idTipoMovimiento})", cn);
                        if (comando.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("" + ex);
                    return false;
                }
                finally
                {
                    cn.Close();
                }

        }
        public bool crearMovimientoLlanta(string idDetalleLlanta, string idSucursal, string cantidad, string fecha, string idTipoMovimiento)
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand comando = new MySqlCommand($"INSERT INTO movimiento VALUES(null,{idDetalleLlanta},null, {idSucursal}, {cantidad}, '{fecha}', {idTipoMovimiento})", cn);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("" + ex);
                return false;
            }
            finally
            {
                cn.Close();
            }

        }

        private string comandoGeneral = $"SELECT S.nombre as 'Nombre Sucursal', D.idDetalleAro, D.Codigo, M.cantidad, T.nombre as 'Tipo de movimiento',  DATE_FORMAT(M.fecha , '%d/%m/%Y %H:%i') as 'Fecha del movimiento'FROM movimiento M inner join detalleAro D on M.idDetalleAro = D.idDetalleAro inner join sucursal S on M.idSucursal = S.idSucursal inner join tipoMovimiento T on M.idTipoMovimiento = T.idTipoMovimiento ";

        public DataSet ListarTodos()
        {

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    MySqlCommand datos = new MySqlCommand(comandoGeneral, cn);

                    MySqlDataAdapter m_datos = new MySqlDataAdapter(datos);
                    ds = new DataSet();
                    m_datos.Fill(ds);

                    return ds;

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("" + ex);
                return null;
            }
            finally
            {
                cn.Close();
            }

        }

        public DataSet buscarMovimiento(string idSucursal, string idDetalle, string codigo, string diseno, bool todas, bool rango, string fechaDesde, string fechaHasta, bool ambos, string idTipoMovimienteo)
        {
            string comando = comandoGeneral;

            try
            {
                using (cn = new Conexion().IniciarConexion())
                {

                    if (todas)
                    {
                        comando += $"where S.idSucursal like '%%'";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $"and D.idDetalleAro like '{idDetalle}'";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $"and D.codigo like '%{codigo}%'";
                        }

                        if (!string.IsNullOrEmpty(diseno))
                        {
                            comando += $"and D.diseno like '%{diseno}%'";
                        }

                        if (ambos == false)
                        {
                            if (!string.IsNullOrEmpty(idTipoMovimienteo))
                            {
                                comando += $"and M.idTipoMovimiento like '{idTipoMovimienteo}' ";
                            }
                        }

                        if (rango)
                        {
                            comando += $"and M.fecha BETWEEN '{fechaDesde}' AND '{fechaHasta}' ";
                        }
                    }
                    else
                    {
                        comando += $"where S.idSucursal like '{idSucursal}'";

                        if (!string.IsNullOrEmpty(idDetalle))
                        {
                            comando += $"and D.idDetalleAro like '{idDetalle}'";
                        }

                        if (!string.IsNullOrEmpty(codigo))
                        {
                            comando += $"and D.codigo like '%{codigo}%'";
                        }

                        if (!string.IsNullOrEmpty(diseno))
                        {
                            comando += $"and D.diseno like '%{diseno}%'";
                        }

                        if (ambos == false)
                        {
                            if (!string.IsNullOrEmpty(idTipoMovimienteo))
                            {
                                comando += $"and M.idTipoMovimiento like '{idTipoMovimienteo}' ";
                            }
                        }

                        if (rango)
                        {
                            comando += $"and M.fecha BETWEEN '{fechaDesde}' AND '{fechaHasta}' ";
                        }
                    }

                    Console.WriteLine(comando);

                    MySqlCommand datos = new MySqlCommand(comando, cn);

                    MySqlDataAdapter m_datos = new MySqlDataAdapter(datos);
                    ds = new DataSet();
                    m_datos.Fill(ds);

                    return ds;

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("" + ex);
                return null;
            }
            finally
            {
                cn.Close();
            }

        }

    }
}
