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
    public partial class MovimientosLlanta : Form
    {
        public MovimientosLlanta()
        {
            InitializeComponent();
            cargarSucursales();
        }

        DSucursal sucursal = new DSucursal();


        void cargarSucursales()
        {
            DataTable dt = sucursal.CrearCombo();

            txtBuscarSucursal2.ValueMember = "idSucursal";
            txtBuscarSucursal2.DisplayMember = "nombre";
            txtBuscarSucursal2.DataSource = dt;
        }

       
        private void generarReporte1(string idSucursal, string idDetalle, string codigo, bool todas, bool rango, string fechaDesde, string fechaHasta, bool ambos, string idTipoMovimiento)
        {
            DReporteLlanta reporte = new DReporteLlanta();
            reporte.crearReporteMovimientos(idSucursal, idDetalle, codigo, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento);

            DReporteLlantaBindingSource.DataSource = reporte;
            MovimientoLlantaListaBindingSource.DataSource = reporte.listaMovimientos;
            ArosMasEntradasBindingSource.DataSource = reporte.listaArosMasEntradas;
            ArosMasSalidasBindingSource.DataSource = reporte.listaArosMasSalidas;

            this.reportViewer2.RefreshReport();

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
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;

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

            string idTipoMovimiento = comboBox1.SelectedIndex.ToString();

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
