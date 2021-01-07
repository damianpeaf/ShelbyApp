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
            actualizarTablaLlantas();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        void cargarSucursales()
        {
            DataTable dt = sucursal.CrearCombo();

            txtBuscarSucursal.ValueMember = "idSucursal";
            txtBuscarSucursal.DisplayMember = "nombre";
            txtBuscarSucursal.DataSource = dt;

            txtBuscarSucursal1.ValueMember = "idSucursal";
            txtBuscarSucursal1.DisplayMember = "nombre";
            txtBuscarSucursal1.DataSource = dt;
        }

        void actualizarTabla()
        {
           DataSet ds = movimiento.listarTodos();
           dataGridView1.DataSource = ds.Tables[0];
        }
        void actualizarTablaLlantas()
        {
            DataSet ds = movimiento.listarTodos1();
            dataGridView2.DataSource = ds.Tables[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            string idSucursal = txtBuscarSucursal1.SelectedValue.ToString();
            string idDetalle = txtId1.Text;
            string codigoDetalle = txtCodigo1.Text;
           

            DateTime dateValue = DateTime.Parse(txtFechaHasta1.Text);
            string fechaHasta = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime dateValue2 = DateTime.Parse(txtFechaDesde1.Text);
            string fechaDesde = dateValue2.ToString("yyyy-MM-dd HH:mm:ss");

            string idTipoMovimiento = tipoMovimiento1.SelectedIndex.ToString();

            bool todas = checkBox6.Checked;
            bool rango = checkBox5.Checked;
            bool ambos = checkBox4.Checked;

            DataSet ds = movimiento.buscarMovimiento1(idSucursal, idDetalle, codigoDetalle, todas, rango, fechaDesde, fechaHasta, ambos, idTipoMovimiento);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizarTablaLlantas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = "";
            dataGridView2.Columns.Clear();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                txtBuscarSucursal1.Enabled = false;
            }
            else
            {
                txtBuscarSucursal1.Enabled = true;

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                txtFechaHasta1.Enabled = true;
                txtFechaDesde1.Enabled = true;
            }
            else
            {
                txtFechaDesde1.Enabled = false;
                txtFechaHasta1.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                tipoMovimiento1.Enabled = false;
            }
            else
            {
                tipoMovimiento1.Enabled = true;

            }
        }

        private void txtBuscarSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*-----------------------------------------------------------------------*/
        /*PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/

    }
}
