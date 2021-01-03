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
    public partial class Sucursales : Form
    {
        DSucursal sucursal = new DSucursal();

        public Sucursales()
        {
            InitializeComponent();
            actualizarTabla();
        }

        void actualizarTabla()
        {
            DataSet ds = sucursal.listarTodos();
            dataGridView1.DataSource = ds.Tables[0];
        }

        /*-----------------------------------------------------------------------*/
        /*PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/

        private void btntListarBuscar_Click(object sender, EventArgs e)
        {
            string idSucursal = txtListarBuscarId.Text;
            string nombreSucursal = txtListarBuscarNombre.Text;
           

            DataSet ds = sucursal.buscarSucursal(idSucursal, nombreSucursal);
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
                string nombre = dataGridView1.Rows[n].Cells[1].Value.ToString();
               

                txtListarSeleccionadoId.Text = id;
                txtListarSeleccionadoNombre.Text = nombre;
              

                IdSeleccionadaAlListar = id;

            }
        }

       

        private void btnListarEliminar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            String[] datoSucursal = sucursal.cargarDatosSucursal(IdSeleccionadaAlListar);
            if (datoSucursal != null)
            {
                txtEliminarId.Text = datoSucursal[0];
                txtEliminarNombre.Text = datoSucursal[1];
               
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
            string nombre = txtCrearNombre.Text;
      


            //validacion
            if (!string.IsNullOrEmpty(nombre) )
            {

               

                    if (sucursal.crearSucursal(nombre))
                    {
                        MessageBox.Show("Sucursal creada");
                        actualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al crear la sucursal");

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
            String[] datosSucursal = sucursal.cargarDatosSucursal(txtEliminarBuscarId.Text);
            if (datosSucursal != null)
            {
                txtEliminarId.Text = datosSucursal[0];
                txtEliminarNombre.Text = datosSucursal[1];
                
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
                if (sucursal.eliminarSucursal(id))
                {
                    MessageBox.Show("Sucursal eliminada");
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar la sucursal");

                }

            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");

            }
        }


        /*-----------------------------------------------------------------------*/
        /* FIN PARTE DE Eliminar*/
        /*-----------------------------------------------------------------------*/

    }
}
