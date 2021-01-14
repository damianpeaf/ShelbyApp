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
using Microsoft.Reporting.WinForms;

namespace Presentacion.App
{
    public partial class InventarioLlantas : Form
    {
        DSucursal sucursal = new DSucursal();


        public InventarioLlantas()
        {
            InitializeComponent();
            cargarSucursales();

        }

        private void cargarSucursales()
        {
            DataTable dt = sucursal.CrearCombo();

           
            txtBuscarSucursal1.ValueMember = "idSucursal";
            txtBuscarSucursal1.DisplayMember = "nombre";
            txtBuscarSucursal1.DataSource = dt;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
        }


        private void generarReporte1(string idSucursal, string idDetalle, string codigo, bool todas, bool costoVisible)
        {
            ReportParameter[] parameters = new ReportParameter[1];
            if (costoVisible)
            {
                parameters[0] = new ReportParameter("columnaCostoVisible", "True");
            }
            else
            {
                parameters[0] = new ReportParameter("columnaCostoVisible", "False");
            }
            this.reportViewer2.LocalReport.SetParameters(parameters);

            DReporteLlanta reporte = new DReporteLlanta();
            reporte.crearReporteInventario(idSucursal, idDetalle, codigo, todas, costoVisible);

            DReporteLlantaBindingSource.DataSource = reporte;
            InventarioLlantaListaBindingSource.DataSource = reporte.listaLlantas;

            this.reportViewer2.RefreshReport();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string idSucursal = txtBuscarSucursal1.SelectedValue.ToString();
            string idDetalle = txtBuscarId1.Text;
            string codigoDetalle = txtBuscarCodigo1.Text;

            bool todas = checkBox2.Checked;

            generarReporte1(idSucursal, idDetalle, codigoDetalle, todas, costoVisible.Checked);
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
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
    }
}
