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
    public partial class Aro : Form
    {
        DAro aro = new DAro();
        DSucursal sucursal = new DSucursal();

        public Aro()
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
            DataSet ds = aro.listarTodos();
            dataGridView1.DataSource = ds.Tables[0];
        }

        /*-----------------------------------------------------------------------*/
        /*PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/

        private void btntListarBuscar_Click(object sender, EventArgs e)
        {
            string idSucursal = txtBuscarSucursal.SelectedValue.ToString();
            string idDetalle = txtBuscarId.Text;
            string codigoDetalle = txtBuscarCodigo.Text;
            string disenoDetalle = txtBuscarDiseno.Text;
            bool todas;

            if (checkBox1.Checked == true)
            {
                todas = true;
            }
            else
            {
                todas = false;

            }

            DataSet ds = aro.buscarAro(idSucursal,idDetalle, codigoDetalle, disenoDetalle, todas);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnListarLimpiar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            dataGridView1.Columns.Clear();

        }

        private void btnListarTodo_Click_1(object sender, EventArgs e)
        {
            actualizarTabla();
        }


        public string IdSeleccionadaAlListar = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            int n = e.RowIndex;

            if (n != -1)
            {
                string sucursal = dataGridView1.Rows[n].Cells[0].Value.ToString();
                string idDetalle = dataGridView1.Rows[n].Cells[1].Value.ToString();
                string codigo = dataGridView1.Rows[n].Cells[2].Value.ToString();
                string cantidad = dataGridView1.Rows[n].Cells[3].Value.ToString();
                string diseno = dataGridView1.Rows[n].Cells[4].Value.ToString();
                string medida = dataGridView1.Rows[n].Cells[5].Value.ToString();
                string pcd = dataGridView1.Rows[n].Cells[6].Value.ToString();
                string pcd2 = dataGridView1.Rows[n].Cells[7].Value.ToString();

                txtSeleccionadoSucursal.Text = sucursal;
                txtSeleccionadoId.Text = idDetalle;
                txtSeleccionadoCodigo.Text = codigo;
                txtSeleccionadoCantidad.Text = cantidad;
                txtSeleccionadoMedida.Text = medida;
                txtSeleccionadoPcd.Text = pcd;
                txtSeleccionadoPcd2.Text = pcd2;
                txtSeleccionadoDiseno.Text = diseno;

                IdSeleccionadaAlListar = idDetalle;

            }
        }

        private void btnListarActualizar_Click(object sender, EventArgs e)
        {

            /*
            tabControl1.SelectedIndex = 2;
            String[] datosDetalle = detalle.cargarDatosDetalle(IdSeleccionadaAlListar);
            if (datosDetalle != null)
            {
                txtActualizarId.Text = datosDetalle[0];
                txtActualizarCodigo.Text = datosDetalle[1];
                txtActualizarMedida.Text = datosDetalle[2];
                txtActualizarPcd.Text = datosDetalle[3];
                txtActualizarPcd2.Text = datosDetalle[4];
                txtActualizarDiseno.Text = datosDetalle[5];

            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }

            */

        }

        /*-----------------------------------------------------------------------*/
        /*FIN PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/


        /*-----------------------------------------------------------------------*/
        /* PARTE DE Actualizar*/
        /*-----------------------------------------------------------------------*/

        private void btnActualizarBuscar_Click_1(object sender, EventArgs e)


        {

            /*

            String[] datosDetalle = detalle.cargarDatosDetalle(txtActualizarBuscarId.Text);
            if (datosDetalle != null)
            {
                txtActualizarId.Text = datosDetalle[0];
                txtActualizarCodigo.Text = datosDetalle[1];
                txtActualizarMedida.Text = datosDetalle[2];
                txtActualizarPcd.Text = datosDetalle[3];
                txtActualizarPcd2.Text = datosDetalle[4];
                txtActualizarDiseno.Text = datosDetalle[5];
            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }

            */

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)

        {
            string id = txtActualizarId.Text;
            string codigo = txtActualizarCodigo.Text;
            string medida = txtActualizarMedida.Text;
            string pcd = txtActualizarPcd.Text;
            string pcd2 = txtActualizarPcd2.Text;
            string diseno = txtActualizarDiseno.Text;

            if (string.IsNullOrEmpty(pcd2))
            {
                pcd = "NA";
            }

            //validacion
            if (!string.IsNullOrEmpty(codigo) && !string.IsNullOrEmpty(medida) && !string.IsNullOrEmpty(pcd) && !string.IsNullOrEmpty(pcd2) && !string.IsNullOrEmpty(diseno))
            {
                /*

                    if (detalle.actualizarDetalle(id,codigo, medida, pcd, pcd2,diseno))
                    {
                        MessageBox.Show("Detalle actualizado");
                        actualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al actualizar detalle");

                    }
                */
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios");

                }
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


        /*-----------------------------------------------------------------------*/
        /* FIN PARTE DE Actualizar*/
        /*-----------------------------------------------------------------------*/


    }
        }
