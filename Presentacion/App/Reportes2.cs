using System;
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
    public partial class Reportes2 : Form
    {
        public Reportes2()
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

            txtBuscarSucursal2.ValueMember = "idSucursal";
            txtBuscarSucursal2.DisplayMember = "nombre";
            txtBuscarSucursal2.DataSource = dt;
        }

        private void Reportes2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
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
        private void generarReporte1(string idSucursal, string idDetalle, string codigo, bool todas, bool rango, string fechaDesde, string fechaHasta, bool ambos, string idTipoMovimiento)
        {
            DReporteLlanta reporte = new DReporteLlanta();
            reporte.crearReporteMovimientos(idSucursal, idDetalle, codigo, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento);

            DReporteAroBindingSource.DataSource = reporte;
            MovimientoAroListaBindingSource.DataSource = reporte.listaMovimientos;
            ArosMasEntradasBindingSource.DataSource = reporte.listaArosMasEntradas;
            ArosMasSalidasBindingSource.DataSource = reporte.listaArosMasSalidas;

            this.reportViewer2.RefreshReport();

        }

        private void btntListarBuscar_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                txtBuscarSucursal2.Enabled = false;
            }
            else
            {
                txtBuscarSucursal2.Enabled = true;

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                txtFechaHasta2.Enabled = true;
                txtFechaDesde2.Enabled = true;
            }
            else
            {
                txtFechaDesde2.Enabled = false;
                txtFechaHasta2.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                tipoMovimiento2.Enabled = false;
            }
            else
            {
                tipoMovimiento2.Enabled = true;

            }
        }

        private void txtFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string idSucursal = txtBuscarSucursal2.SelectedValue.ToString();
            string idDetalle = txtId2.Text;
            string codigoDetalle = txtCodigo2.Text;

            DateTime dateValue = DateTime.Parse(txtFechaHasta2.Text);
            string fechaHasta = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime dateValue2 = DateTime.Parse(txtFechaDesde2.Text);
            string fechaDesde = dateValue2.ToString("yyyy-MM-dd HH:mm:ss");

            string idTipoMovimiento = tipoMovimiento2.SelectedIndex.ToString();

            bool todas = checkBox6.Checked;
            bool rango = checkBox5.Checked;
            bool ambos = checkBox2.Checked;

            generarReporte1(idSucursal, idDetalle, codigoDetalle, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento);
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
