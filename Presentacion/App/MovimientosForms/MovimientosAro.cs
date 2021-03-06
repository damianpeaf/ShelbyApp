﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion.App
{
    public partial class MovimientosAro : Form
    {
        public MovimientosAro()
        {
            InitializeComponent();
            cargarSucursales();
        }

        DSucursal sucursal = new DSucursal();


        void cargarSucursales()
        {
            DataTable dt = sucursal.CrearCombo();

            txtBuscarSucursal.ValueMember = "idSucursal";
            txtBuscarSucursal.DisplayMember = "nombre";
            txtBuscarSucursal.DataSource = dt;

        }

        private void Reportes2_Load(object sender, EventArgs e)
        {
        }

        private void generarReporte(string idSucursal, string idDetalle, string codigo, bool todas, bool rango, string fechaDesde, string fechaHasta, bool ambos, string idTipoMovimiento)
        {
            DReporteAro reporte = new DReporteAro();
            reporte.crearReporteMovimientos(idSucursal, idDetalle, codigo, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento);

            DReporteAroBindingSource.DataSource = reporte;
            MovimientoAroListaBindingSource.DataSource = reporte.listaMovimientos;
            ArosMasEntradasBindingSource.DataSource = reporte.listaArosMasEntradas;
            ArosMasSalidasBindingSource.DataSource = reporte.listaArosMasSalidas;

            this.reportViewer1.RefreshReport();

        }


        private void btntListarBuscar_Click_1(object sender, EventArgs e)
        {
            string idSucursal = txtBuscarSucursal.SelectedValue.ToString();
            string idDetalle = txtId.Text;
            string codigoDetalle = txtCodigo.Text;

            DateTime dateValue = DateTime.Parse(txtFechaHasta.Text);
            string fechaHasta = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime dateValue2 = DateTime.Parse(txtFechaDesde.Text);
            string fechaDesde = dateValue2.ToString("yyyy-MM-dd HH:mm:ss");

            string idTipoMovimiento = tipoMovimiento.SelectedIndex.ToString();

            bool todas = checkBox1.Checked;
            bool rango = checkBox3.Checked;
            bool ambos = checkBox4.Checked;

            generarReporte(idSucursal, idDetalle, codigoDetalle, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento);
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                tipoMovimiento.Enabled = false;
            }
            else
            {
                tipoMovimiento.Enabled = true;

            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtBuscarSucursal.Enabled = false;
            }
            else
            {
                txtBuscarSucursal.Enabled = true;

            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                txtFechaHasta.Enabled = true;
                txtFechaDesde.Enabled = true;
            }
            else
            {
                txtFechaDesde.Enabled = false;
                txtFechaHasta.Enabled = false;
            }
        }
    }
}
