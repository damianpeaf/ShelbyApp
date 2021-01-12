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
    public partial class DetalleLlanta : Form
    {
        DDetalleLlanta detalle = new DDetalleLlanta();
        Menu menuP;

        public DetalleLlanta(Menu menu)
        {
            InitializeComponent();
            actualizarTabla();
            cargarMarcas();
            menuP = menu;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        void actualizarTabla()
        {
            DataSet ds = detalle.listarTodos();
            dataGridView1.DataSource = ds.Tables[0];
        }
      

        /*-----------------------------------------------------------------------*/
        /*PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/

        private void btntListarBuscar_Click_1(object sender, EventArgs e)
        {
            string idDetalle = txtListarBuscarId.Text;
            string codigoDetalle = txtListarBuscarCodigo.Text;
            string medidaDetalle = txtListarBuscarMedida.Text;
            string marcaDetalle = txtListarBuscarMarcas.SelectedValue.ToString();

            DataSet ds = detalle.buscarDetalle(idDetalle, codigoDetalle, medidaDetalle, marcaDetalle);
            if (ds!= null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        private void btnListarLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            dataGridView1.Columns.Clear();

        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }


        public string IdSeleccionadaAlListar = "";
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)

        {
            int n = e.RowIndex;

            if (n != -1)
            {
                string id = dataGridView1.Rows[n].Cells[0].Value.ToString();
                string codigo = dataGridView1.Rows[n].Cells[1].Value.ToString();
                string medida = dataGridView1.Rows[n].Cells[2].Value.ToString();
                string marca = dataGridView1.Rows[n].Cells[3].Value.ToString();
           


                txtListarSeleccionadoId.Text = id;
                txtListarSeleccionadoCodigo.Text = codigo;
                txtListarSeleccionadoMedida.Text = medida;
                txtListarSeleccionadoPcd.Text = marca;
             

                IdSeleccionadaAlListar = id;

            }
        }

        private void btnListarActualizar_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            String[] datosDetalle = detalle.cargarDatosDetalle(IdSeleccionadaAlListar);
            if (datosDetalle != null)
            {
                txtActualizarId.Text = datosDetalle[0];
                txtActualizarCodigo.Text = datosDetalle[1];
                txtActualizarMedida.Text = datosDetalle[2];
                txtListarSeleccionadoPcd.Text = datosDetalle[3];
           

            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }

        }

        private void btnListarEliminar_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            String[] datosDetalle = detalle.cargarDatosDetalle(IdSeleccionadaAlListar);
            if (datosDetalle != null)
            {
                txtEliminarId.Text = datosDetalle[0];
                txtEliminarCodigo.Text = datosDetalle[1];
                txtEliminarMedida.Text = datosDetalle[2];
                txtEliminarPcd.Text = datosDetalle[3];
            
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
        private void btmCrear_Click_1(object sender, EventArgs e)
        {
            string codigo = txtCrearCodigo.Text;
            string medida = txtCrearMedida.Text;
            string marca = txtCrearMarca.SelectedValue.ToString();
            string stockInicial = txtCrearStockInicial.Text;
        

            

            //validacion
            if (!string.IsNullOrEmpty(codigo) && !string.IsNullOrEmpty(medida) && !string.IsNullOrEmpty(marca) && !string.IsNullOrEmpty(stockInicial))
            {


                if (detalle.crearDetalle(codigo, medida, marca, stockInicial))
                {
                    MessageBox.Show("Detalle creado");
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Hubo un error al crear detalle");

                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");

            }
        }
        private void btmCrear_Click(object sender, EventArgs e)
        {
            

        }

        /*-----------------------------------------------------------------------*/
        /*FIN PARTE DE Crear*/
        /*-----------------------------------------------------------------------*/


        /*-----------------------------------------------------------------------*/
        /* PARTE DE Actualizar*/
        /*-----------------------------------------------------------------------*/

        private void btnActualizarBuscar_Click_1(object sender, EventArgs e)


        {
            String[] datosDetalle = detalle.cargarDatosDetalle(txtActualizarBuscarId.Text);
            if (datosDetalle != null)
            {
                txtActualizarId.Text = datosDetalle[0];
                txtActualizarCodigo.Text = datosDetalle[1];
                txtActualizarMedida.Text = datosDetalle[2];
                txtActualizarMarca.Text = datosDetalle[3];
       
            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }

        }

        private void btnActualizar_Click_1(object sender, EventArgs e)

        {
            string id = txtActualizarId.Text;
            string codigo = txtActualizarCodigo.Text;
            string medida = txtActualizarMedida.Text;
            string marca = txtCrearMarca.SelectedValue.ToString();


            //validacion
            if (!string.IsNullOrEmpty(codigo) && !string.IsNullOrEmpty(medida) && !string.IsNullOrEmpty(marca))
            {
                if (detalle.actualizarDetalle(id,codigo, medida, marca))
                {
                    MessageBox.Show("Detalle actualizado");
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar detalle");

                }

            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");

            }
        }

        /*-----------------------------------------------------------------------*/
        /* FIN PARTE DE Actualizar*/
        /*-----------------------------------------------------------------------*/

        /*-----------------------------------------------------------------------*/
        /* PARTE DE Eliminar*/
        /*-----------------------------------------------------------------------*/

        private void btnEliminarBuscar_Click_1(object sender, EventArgs e)
        {
            String[] datosDetalle = detalle.cargarDatosDetalle(txtEliminarBuscarId.Text);
            if (datosDetalle != null)
            {
                txtEliminarId.Text = datosDetalle[0];
                txtEliminarCodigo.Text = datosDetalle[1];
                txtEliminarMedida.Text = datosDetalle[2];
                txtEliminarPcd.Text = datosDetalle[3];
             
            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            string id = txtEliminarId.Text;

            //validacion
            if (!string.IsNullOrEmpty(id))
            {
                DialogResult result = MessageBox.Show("Este detalle de llanta esta relacionada con ciertos movimientos y productos, ¿Realemente quieres eliminarla? ", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (detalle.eliminarDetalle(id))
                    {
                        MessageBox.Show("Detalle eliminado");
                        actualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar detalle");

                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Detalle NO eliminada");
                }
                else
                {
                    MessageBox.Show("Hubo un error");
                }             

            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");

            }
        }
        void cargarMarcas()
        {
            DataTable dt = detalle.ComboMarca();
            txtListarBuscarMarcas.ValueMember = "idMarca";
            txtListarBuscarMarcas.DisplayMember = "nombre";
            txtListarBuscarMarcas.DataSource = dt;

            txtCrearMarca.ValueMember = "idMarca";
            txtCrearMarca.DisplayMember = "nombre";
            txtCrearMarca.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Marcas form = new Marcas();
            form.Show();
          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marcas form = new Marcas();
            form.Show();
          
        }

        private void DetalleLlanta_Load(object sender, EventArgs e)
        {
            DataTable dt = detalle.ComboMarca();
            txtListarBuscarMarcas.ValueMember = "idMarca";
            txtListarBuscarMarcas.DisplayMember = "nombre";
            txtListarBuscarMarcas.DataSource = dt;

            txtCrearMarca.ValueMember = "idMarca";
            txtCrearMarca.DisplayMember = "nombre";
            txtCrearMarca.DataSource = dt;

            txtActualizarMarca.ValueMember = "idMarca";
            txtActualizarMarca.DisplayMember = "nombre";
            txtActualizarMarca.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
                
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DataTable dt = detalle.ComboMarca();
            txtListarBuscarMarcas.ValueMember = "idMarca";
            txtListarBuscarMarcas.DisplayMember = "nombre";
            txtListarBuscarMarcas.DataSource = dt;

            txtCrearMarca.ValueMember = "idMarca";
            txtCrearMarca.DisplayMember = "nombre";
            txtCrearMarca.DataSource = dt;

            txtActualizarMarca.ValueMember = "idMarca";
            txtActualizarMarca.DisplayMember = "nombre";
            txtActualizarMarca.DataSource = dt;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DataTable dt = detalle.ComboMarca();
            txtListarBuscarMarcas.ValueMember = "idMarca";
            txtListarBuscarMarcas.DisplayMember = "nombre";
            txtListarBuscarMarcas.DataSource = dt;

            txtCrearMarca.ValueMember = "idMarca";
            txtCrearMarca.DisplayMember = "nombre";
            txtCrearMarca.DataSource = dt;

            txtActualizarMarca.ValueMember = "idMarca";
            txtActualizarMarca.DisplayMember = "nombre";
            txtActualizarMarca.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuP.AbrirForm2(new Llantas(IdSeleccionadaAlListar));
            this.Close();
        }

        private void txtCrearStockInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }


        /*-----------------------------------------------------------------------*/
        /* FIN PARTE DE Eliminar*/
        /*-----------------------------------------------------------------------*/

    }
}
