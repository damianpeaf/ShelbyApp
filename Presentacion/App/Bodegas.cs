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
    public partial class Bodegas : Form
    {
        DBodega bode = new DBodega();
        DSucursal sucursal = new DSucursal();

        public Bodegas()
        {
            InitializeComponent();
            actualizarTabla();
            cargarSucursales();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }
        void cargarSucursales()
        {
            DataTable dt = sucursal.CrearCombo();

            txtListarBuscarSucursal.ValueMember = "idSucursal";
            txtListarBuscarSucursal.DisplayMember = "nombre";
            txtListarBuscarSucursal.DataSource = dt;

            txtAsignarSucursal.ValueMember = "idSucursal";
            txtAsignarSucursal.DisplayMember = "nombre";
            txtAsignarSucursal.DataSource = dt;

            txtASucursal.ValueMember = "idSucursal";
            txtASucursal.DisplayMember = "nombre";
            txtASucursal.DataSource = dt;
        }

        void actualizarTabla()
        {
            DataSet ds = bode.listarTodos();
            dataGridView1.DataSource = ds.Tables[0];
        }

        /*-----------------------------------------------------------------------*/
        /*PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/

        private void btntListarBuscar_Click(object sender, EventArgs e)
        {
            string idSucursal = txtListarBuscarSucursal.SelectedValue.ToString();
            string idBodega= txtListarBuscarId.Text;
            string nombreBodega = txtListarBuscarNombre.Text;
            bool todas;

            if (checkBox1.Checked == true)
            {
                todas = true;
            }
            else
            {
                todas = false;

            }

            DataSet ds = bode.buscarBodega(idBodega, nombreBodega, idSucursal, todas);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            dataGridView1.Columns.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            actualizarTabla();
        }


        public string IdSeleccionadaAlListar = "";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                string id = dataGridView1.Rows[n].Cells[0].Value.ToString();
                string nombreBodega = dataGridView1.Rows[n].Cells[1].Value.ToString();
                string nombreSucursal = dataGridView1.Rows[n].Cells[2].Value.ToString();


                txtListarSeleccionadoId.Text = id;
                txtListarSeleccionadoNombreBodega.Text = nombreBodega;
                txtListarSeleccionadoNombreSucursal.Text = nombreSucursal;
              

                IdSeleccionadaAlListar = id;

            }
        }

       

        private void btnListarEliminar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            String[] datoSucursal =bode.cargarDatosBodega(IdSeleccionadaAlListar);
            if (datoSucursal != null)
            {
                txtEliminarId.Text = datoSucursal[0];
                txtEliminarNombreB.Text = datoSucursal[1];
                txtEliminarNombreS.Text = datoSucursal[2];

            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }
        }

        /*-----------------------------------------------------------------------*/
        /*FIN PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/


        /*-----------------------------------------------------------------------*/
        /*PARTE DE Crear*/
        /*-----------------------------------------------------------------------*/

        private void btmCrear_Click(object sender, EventArgs e)
        {
            string nombreB = txtCrearNombre.Text;
            string nombreS = txtAsignarSucursal.SelectedValue.ToString();



            //validacion
            if (!string.IsNullOrEmpty(nombreB) && !string.IsNullOrEmpty(nombreS))
            {

               

                    if (bode.crearBodega(nombreB, nombreS))
                    {
                        MessageBox.Show("Bodega creada");
                        actualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al crear la bodega");

                    }
                
               
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");

            }

        }

        /*-----------------------------------------------------------------------*/
        /*FIN PARTE DE Crear*/
        /*-----------------------------------------------------------------------*/


        /*-----------------------------------------------------------------------*/
        /* PARTE DE Actualizar*/
        /*-----------------------------------------------------------------------*/

        

      

        /*-----------------------------------------------------------------------*/
        /* FIN PARTE DE Actualizar*/
        /*-----------------------------------------------------------------------*/

        /*-----------------------------------------------------------------------*/
        /* PARTE DE Eliminar*/
        /*-----------------------------------------------------------------------*/

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            String[] datosSucursal = bode.cargarDatosBodega(txtEliminarBuscarId.Text);
            if (datosSucursal != null)
            {
                txtEliminarId.Text = datosSucursal[0];
                txtEliminarNombreB.Text = datosSucursal[1];
                txtEliminarNombreS.Text = datosSucursal[2];

            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtEliminarId.Text;

            //validacion
            if (!string.IsNullOrEmpty(id))
            {
                if (bode.eliminarBodega(id))
                {
                    MessageBox.Show("Bodega eliminada");
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar la Bodega");

                }

            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");

            }
        }

        private void btnActuBuscar_Click(object sender, EventArgs e)
        {
            String[] datosSucursal = bode.cargarDatosBodega(txtActBuscarId.Text);
            if (datosSucursal != null)
            {
                txtAID.Text = datosSucursal[0];
                txtABodega.Text = datosSucursal[1];
                txtASucursal.Text = datosSucursal[2];

            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            String[] datoSucursal = bode.cargarDatosBodega(IdSeleccionadaAlListar);
            if (datoSucursal != null)
            {
                txtAID.Text = datoSucursal[0];
                txtABodega.Text = datoSucursal[1];
                txtASucursal.Text = datoSucursal[2];

            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtAID.Text;
            string nombreB = txtABodega.Text;
            string nombreS = txtASucursal.SelectedValue.ToString();




            //validacion
            if (!string.IsNullOrEmpty(nombreB) && !string.IsNullOrEmpty(nombreS))
            {
                if (bode.actualizarBodega(id, nombreB, nombreS))
                {
                    MessageBox.Show("Bodega actualizada");
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar la Bodega");

                }

            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");

            }
        }

        private void txtListarBuscarSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtListarBuscarSucursal.Enabled = false;
            }
            else
            {
                txtListarBuscarSucursal.Enabled = true;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        /*-----------------------------------------------------------------------*/
        /* FIN PARTE DE Eliminar*/
        /*-----------------------------------------------------------------------*/

    }
}
