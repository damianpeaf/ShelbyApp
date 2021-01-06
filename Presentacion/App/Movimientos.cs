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
using Comun;

namespace Presentacion.App
{
    public partial class Movimientos : Form
    {
        DSucursal sucursal = new DSucursal();
        DMovimiento movimiento = new DMovimiento();

        public Movimientos()
        {
            InitializeComponent();
            actualizarTabla();
            cargarSucursales();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            
        }

        void cargarSucursales()
        {
            DataTable dt = sucursal.CrearCombo();

            txtBuscarSucursal.ValueMember = "idSucursal";
            txtBuscarSucursal.DisplayMember = "nombre";
            txtBuscarSucursal.DataSource = dt;
        }

        void actualizarTabla()
        {
           DataSet ds = movimiento.listarTodos();
           dataGridView1.DataSource = ds.Tables[0];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void btntListarBuscar_Click(object sender, EventArgs e)
        {
            string idSucursal = txtBuscarSucursal.SelectedValue.ToString();
            string idDetalle = txtId.Text;
            string codigoDetalle = txtCodigo.Text;
            string disenoDetalle = txtDiseno.Text;

            DateTime dateValue = DateTime.Parse(txtFechaHasta.Text);
            string fechaHasta = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime dateValue2 = DateTime.Parse(txtFechaDesde.Text);
            string fechaDesde = dateValue2.ToString("yyyy-MM-dd HH:mm:ss");

            string idTipoMovimiento = tipoMovimiento.SelectedIndex.ToString();

            bool todas = checkBox1.Checked;
            bool rango = checkBox2.Checked;
            bool ambos = checkBox3.Checked;

            DataSet ds = movimiento.buscarMovimiento(idSucursal, idDetalle, codigoDetalle, disenoDetalle, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                tipoMovimiento.Enabled = false;
            }
            else
            {
                tipoMovimiento.Enabled = true;

            }
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void btnListarLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            dataGridView1.Columns.Clear();
        }

        /*-----------------------------------------------------------------------*/
        /*PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/

    }
}
