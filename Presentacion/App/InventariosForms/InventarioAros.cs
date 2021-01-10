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
    public partial class InventarioAros : Form
    {
        DSucursal sucursal = new DSucursal();


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

        private void Reportes_Load(object sender, EventArgs e)
        {

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

        private void btntListarBuscar_Click_1(object sender, EventArgs e)
        {
            string idSucursal = txtBuscarSucursal.SelectedValue.ToString();
            string idDetalle = txtBuscarId.Text;
            string codigoDetalle = txtBuscarCodigo.Text;

            bool todas = checkBox1.Checked;

            generarReporte(idSucursal, idDetalle, codigoDetalle, todas);
        }
    }
}
