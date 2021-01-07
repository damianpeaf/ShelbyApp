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
    public partial class Reportes : Form
    {
        DSucursal sucursal = new DSucursal();


        public Reportes()
        {
            InitializeComponent();
            cargarSucursales();

        }

        private void cargarSucursales()
        {
            DataTable dt = sucursal.CrearCombo();

            txtBuscarSucursal.ValueMember = "idSucursal";
            txtBuscarSucursal.DisplayMember = "nombre";
            txtBuscarSucursal.DataSource = dt;
            txtBuscarSucursal1.ValueMember = "idSucursal";
            txtBuscarSucursal1.DisplayMember = "nombre";
            txtBuscarSucursal1.DataSource = dt;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void generarReporte(string idSucursal, string idDetalle, string codigo, bool todas)
        {
            DReporteAro reporte = new DReporteAro();
            reporte.crearReporteInventario(idSucursal, idDetalle, codigo, todas);

            DReporteAroBindingSource.DataSource = reporte;
            InventarioAroListaBindingSource.DataSource = reporte.listaAros;

            this.reportViewer1.RefreshReport();

        }
        private void generarReporte1(string idSucursal, string idDetalle, string codigo, bool todas)
        {
            DReporteLlanta reporte = new DReporteLlanta();
            reporte.crearReporteInventario(idSucursal, idDetalle, codigo, todas);

            DReporteLlantaBindingSource.DataSource = reporte;
            InventarioLlantaListaBindingSource.DataSource = reporte.listaLlantas;

            this.reportViewer2.RefreshReport();

        }

        private void btntListarBuscar_Click(object sender, EventArgs e)
        {
            string idSucursal = txtBuscarSucursal.SelectedValue.ToString();
            string idDetalle = txtBuscarId.Text;
            string codigoDetalle = txtBuscarCodigo.Text;

            bool todas = checkBox1.Checked;

            generarReporte(idSucursal, idDetalle, codigoDetalle, todas);
        }

        private void txtBuscarSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtBuscarSucursal1.Enabled = false;
            }
            else
            {
                txtBuscarSucursal1.Enabled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idSucursal = txtBuscarSucursal1.SelectedValue.ToString();
            string idDetalle = txtBuscarId1.Text;
            string codigoDetalle = txtBuscarCodigo1.Text;

            bool todas = checkBox2.Checked;

            generarReporte1(idSucursal, idDetalle, codigoDetalle, todas);
        }
    }
}
