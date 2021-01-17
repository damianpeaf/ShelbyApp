using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun;
using Dominio;

namespace Presentacion.App
{
    public partial class DetalleAro : Form
    {
        DDetalleAro detalle = new DDetalleAro();

        Menu menuP;
        public DetalleAro(Menu menu)
        {
            InitializeComponent();
            actualizarTabla();

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
            string disenoDetalle = txtListarBuscarDiseno.Text;

            DataSet ds = detalle.buscarDetalle(idDetalle, codigoDetalle, medidaDetalle, disenoDetalle);
            dataGridView1.DataSource = ds.Tables[0];

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
                string pcd = dataGridView1.Rows[n].Cells[3].Value.ToString();
                string pcd2 = dataGridView1.Rows[n].Cells[4].Value.ToString();
                string diseno = dataGridView1.Rows[n].Cells[5].Value.ToString();
                string costo = dataGridView1.Rows[n].Cells[6].Value.ToString();
                string precio = dataGridView1.Rows[n].Cells[7].Value.ToString();


                txtListarSeleccionadoId.Text = id;
                txtListarSeleccionadoCodigo.Text = codigo;
                txtListarSeleccionadoMedida.Text = medida;
                txtListarSeleccionadoPcd.Text = pcd;
                txtListarSeleccionadoPcd2.Text = pcd2;
                txtListarSeleccionadoDiseno.Text = diseno;
                txtListarSeleccionadoCosto.Text = costo;
                txtListarSeleccionadoPrecio.Text = precio;

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
                txtActualizarPcd.Text = datosDetalle[3];
                txtActualizarPcd2.Text = datosDetalle[4];
                txtActualizarDiseno.Text = datosDetalle[5];
                txtActualizarCosto.Text = datosDetalle[6];
                txtActualizarPrecio.Text = datosDetalle[7];

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
                txtEliminarPcd2.Text = datosDetalle[4];
                txtEliminarDiseno.Text = datosDetalle[5];
                txtEliminarCosto.Text = datosDetalle[6];
                txtEliminarPrecio.Text = datosDetalle[7];
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
            string pcd = txtCrearPcd.Text;
            string pcd2 = txtCrearPcd2.Text;
            string diseno = txtCrearDiseno.Text;
            string costo = txtCrearCosto.Text;
            string precio = txtCrearPrecio.Text;
            string stockInicial = txtCrearStockInicial.Text;
            if (string.IsNullOrEmpty(pcd2))
            {
                pcd2 = "NA";
            }

            //validacion
            if (!string.IsNullOrEmpty(codigo) && !string.IsNullOrEmpty(medida) && !string.IsNullOrEmpty(pcd) && !string.IsNullOrEmpty(pcd2) && !string.IsNullOrEmpty(diseno) && !string.IsNullOrEmpty(costo) && !string.IsNullOrEmpty(precio) && !string.IsNullOrEmpty(stockInicial))
            {
                if (detalle.crearDetalle(codigo, medida, pcd, pcd2, diseno,costo, precio, stockInicial))
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
                txtActualizarPcd.Text = datosDetalle[3];
                txtActualizarPcd2.Text = datosDetalle[4];
                txtActualizarDiseno.Text = datosDetalle[5];
                txtActualizarCosto.Text = datosDetalle[6];
                txtActualizarPrecio.Text = datosDetalle[7];
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
            string pcd = txtActualizarPcd.Text;
            string pcd2 = txtActualizarPcd2.Text;
            string diseno = txtActualizarDiseno.Text;
            string costo = txtActualizarCosto.Text;
            string precio = txtActualizarPrecio.Text;

            if (string.IsNullOrEmpty(pcd2))
            {
                pcd = "NA";
            }

            //validacion
            if (!string.IsNullOrEmpty(codigo) && !string.IsNullOrEmpty(medida) && !string.IsNullOrEmpty(pcd) && !string.IsNullOrEmpty(pcd2) && !string.IsNullOrEmpty(diseno) && !string.IsNullOrEmpty(costo) && !string.IsNullOrEmpty(precio))
            {
                if (detalle.actualizarDetalle(id,codigo, medida, pcd, pcd2,diseno, costo, precio))
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
                txtEliminarPcd2.Text = datosDetalle[4];
                txtEliminarDiseno.Text = datosDetalle[5];
                txtEliminarCosto.Text = datosDetalle[6];
                txtEliminarPrecio.Text = datosDetalle[7];
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
                DialogResult result = MessageBox.Show("Este detalle de aro esta relacionada con ciertos movimientos y productos, ¿Realemente quieres eliminarla? ", "Confirmación", MessageBoxButtons.YesNo);
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

        private void button1_Click(object sender, EventArgs e)
        {

            menuP.AbrirForm2(new Aro(IdSeleccionadaAlListar));
            this.Close();
        }

        private void label31_Click(object sender, EventArgs e)
        {

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

        private void DetalleAro_Load(object sender, EventArgs e)
        {
            if (info_usuario.idRol == "2")
            {
                txtCrearStockInicial.Text = "0";
                txtCrearStockInicial.Enabled = false;
            }
        }


        /*-----------------------------------------------------------------------*/
        /* FIN PARTE DE Eliminar*/
        /*-----------------------------------------------------------------------*/

    }
}
