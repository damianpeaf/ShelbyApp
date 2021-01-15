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
    public partial class InventarioAros : Form
    {
        DSucursal sucursal = new DSucursal();
        DBodega bodega = new DBodega();


        public InventarioAros()
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

        }

        void cargarBodegas(string idSucursal)
        {
            DataTable dt = bodega.CrearCombo(idSucursal);

            comboBodegas.ValueMember = "idBodega";
            comboBodegas.DisplayMember = "nombre";
            comboBodegas.DataSource = dt;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void generarReporte(string idSucursal, string idDetalle, string codigo, bool todas, bool costoVisible)
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
            this.reportViewer1.LocalReport.SetParameters(parameters);

            DReporteAro reporte = new DReporteAro();
            reporte.crearReporteInventario(idSucursal, idDetalle, codigo, todas, false, false, null);

            DReporteAroBindingSource.DataSource = reporte;
            InventarioAroListaBindingSource.DataSource = reporte.listaAros;

            this.reportViewer1.RefreshReport();

        }

        private void generarReporteBodega(string idSucursal, string idDetalle, string codigo, bool todas, bool costoVisible, bool todasBodegas, string idBodega)
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
            this.reportViewer1.LocalReport.SetParameters(parameters);

            DReporteAro reporte = new DReporteAro();
            reporte.crearReporteInventario(idSucursal, idDetalle, codigo, todas, true, todasBodegas, idBodega);

            DReporteAroBindingSource.DataSource = reporte;
            InventarioAroListaBindingSource.DataSource = reporte.listaAros;

            this.reportViewer1.RefreshReport();

        }

        private void btntListarBuscar_Click_1(object sender, EventArgs e)
        {
            string idSucursal = txtBuscarSucursal.SelectedValue.ToString();
            string idDetalle = txtBuscarId.Text;
            string codigoDetalle = txtBuscarCodigo.Text;
            string idBodega = comboBodegas.SelectedValue.ToString();

            bool todas = checkBox1.Checked;
            bool todasBodegas;

            if (checkBox2.Checked == true)
            {
                todasBodegas = true;
            }
            else
            {
                todasBodegas = false;

            }

            if (buscarBodega.Checked)
            {
                generarReporteBodega(idSucursal, idDetalle, codigoDetalle, todas, costoVisible.Checked, todasBodegas,idBodega);
            }
            else
            {
                generarReporte(idSucursal, idDetalle, codigoDetalle, todas, costoVisible.Checked);
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

            if (checkBox1.Checked)
            {
                cargarBodegas(null);
            }
            else
            {
                string idSucursal = txtBuscarSucursal.SelectedValue.ToString();

                cargarBodegas(idSucursal);
            }
        }

        private void buscarBodega_CheckedChanged(object sender, EventArgs e)
        {
            if (buscarBodega.Checked)
            {
                groupBox5.Enabled = true;
            }
            else
            {
                groupBox5.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBodegas.Enabled = false;
            }
            else
            {
                comboBodegas.Enabled = true;
            }
        }

        private void txtBuscarSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cargarBodegas(null);
            }
            else
            {
                string idSucursal = txtBuscarSucursal.SelectedValue.ToString();

                cargarBodegas(idSucursal);
            }
        }
    }
}
