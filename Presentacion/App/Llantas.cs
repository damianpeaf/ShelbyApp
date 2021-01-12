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
    public partial class Llantas : Form
    {
        DLlanta llanta = new DLlanta();
        DSucursal sucursal = new DSucursal();
        DMovimiento movimiento = new DMovimiento();

        public Llantas(string IdSeleccionadaAlListar)
        {
            InitializeComponent();
            actualizarTabla();
            cargarSucursales();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (!string.IsNullOrEmpty(IdSeleccionadaAlListar))
            {

                DataSet ds = llanta.buscarLlanta("", IdSeleccionadaAlListar, "",  true);
                dataGridView1.DataSource = ds.Tables[0];
            }
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
            DataSet ds = llanta.listarTodos();
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
            bool todas;

            if (checkBox1.Checked == true)
            {
                todas = true;
            }
            else
            {
                todas = false;

            }

            DataSet ds = llanta.buscarLlanta(idSucursal, idDetalle, codigoDetalle,  todas);
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
                string idMarca = dataGridView1.Rows[n].Cells[4].Value.ToString();

                string medida = dataGridView1.Rows[n].Cells[5].Value.ToString();
             
                string idLlanta = dataGridView1.Rows[n].Cells[8].Value.ToString();


                txtSeleccionadoSucursal.Text = sucursal;
                txtSeleccionadoId.Text = idDetalle;
                txtSeleccionadoCodigo.Text = codigo;
                txtSeleccionadoCantidad.Text = cantidad;
                txtSeleccionadoMedida.Text = medida;
                txtIdLlantas.Text = idLlanta;
                txtSeleccionadoMarca.Text = idMarca;
                IdSeleccionadaAlListar = idLlanta;

            }
        }

        private void btnListarActualizar_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 1;
            String[] datosLlantas = llanta.cargarDatosLlanta(IdSeleccionadaAlListar);
            if (datosLlantas != null)
            {
                string sucursal = datosLlantas[0];
                string idDetalle = datosLlantas[1];
                string codigo = datosLlantas[2];
                string cantidad = datosLlantas[3];
                string idmarca = datosLlantas[4];
                string medida = datosLlantas[5];
                string idLlanta = datosLlantas[6];
                string idSucursal = datosLlantas[7];

                txtASucursal.Text = sucursal;
                txtAIdDetalle.Text = idDetalle;
                txtACodigo.Text = codigo;
                txtACantidad.Text = cantidad;
                txtAMedida.Text = medida;
                txtAIdLlantas.Text = idLlanta;
                txtAIdSucursal.Text = idSucursal;
                txtAMarca.Text = idmarca;

            }
            else
            {
                MessageBox.Show("Registro no encontrado " + IdSeleccionadaAlListar);
            }

            calcularTotal();



        }

        /*-----------------------------------------------------------------------*/
        /*FIN PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/


        /*-----------------------------------------------------------------------*/
        /* PARTE DE Actualizar*/
        /*-----------------------------------------------------------------------*/

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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnActualizarBuscar_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 1;
            String[] datosLlantas = llanta.cargarDatosLlanta(txtABuscar.Text);
            if (datosLlantas != null)
            {
                string sucursal = datosLlantas[0];
                string idDetalle = datosLlantas[1];
                string codigo = datosLlantas[2];
                string cantidad = datosLlantas[3];
                string idmarca = datosLlantas[4];
                string medida = datosLlantas[5];
                string idLlanta = datosLlantas[6];
                string idSucursal = datosLlantas[7];

                txtASucursal.Text = sucursal;
                txtAIdDetalle.Text = idDetalle;
                txtACodigo.Text = codigo;
                txtACantidad.Text = cantidad;
                txtAMedida.Text = medida;
                txtAIdLlantas.Text = idLlanta;
                txtAIdSucursal.Text = idSucursal;
                txtAMarca.Text = idmarca;

            }
            else
            {
                MessageBox.Show("Registro no encontrado " + IdSeleccionadaAlListar);

            }
            calcularTotal();

        }

        int entrada=3;

        void calcularTotal()
        {
            if (entrada == 0 || entrada == 1)
            {
                if (!string.IsNullOrEmpty(txtAModificar.Text) && !string.IsNullOrEmpty(txtACantidad.Text))
                {

                    int total = 0;

                    if (entrada==1)
                    {
                        total = int.Parse(txtAModificar.Text) + int.Parse(txtACantidad.Text);
                    }
                    else if(entrada == 0)
                    {
                        total = int.Parse(txtACantidad.Text) - int.Parse(txtAModificar.Text);
                    }

                    txtATotal.Text = total.ToString();
                }
            }
        
        }

        private void tipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            entrada = tipoMovimiento.SelectedIndex;
            calcularTotal();

            
        }

        bool noVacio(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txtAModificar_TextChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //actualizar Llantas
            //insertar movimiento

            string idEspecifica = txtAIdLlantas.Text;

            string idDetalleLlanta = txtAIdDetalle.Text;

            string idSucursal = txtAIdSucursal.Text;

            string cantidadAnterior = txtACantidad.Text;
            string cantidadEntrante = txtAModificar.Text;
            string cantidadNueva = txtATotal.Text;

            string idTipoMovimiento = tipoMovimiento.SelectedIndex.ToString();

            //correcciones de formato de fecha
            string fecha = fechaMovimiento.Text;
            DateTime dateValue = DateTime.Parse(fecha);
            string formatForMySql = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

            string idUsuario = info_usuario.idUsuario;

            //validacion
            if (noVacio(idEspecifica) &&  noVacio(cantidadAnterior) && noVacio(cantidadEntrante) && noVacio(cantidadNueva) && (tipoMovimiento.SelectedIndex == 0 || tipoMovimiento.SelectedIndex == 1) && noVacio(fecha) && noVacio(idUsuario))
            {
                if (int.Parse(cantidadNueva)>=0)
                {
                    //todo bien capo
                    if (llanta.actualizarInventario(idEspecifica,cantidadNueva, formatForMySql, idUsuario))
                    {
                        if (movimiento.crearMovimientoLlanta(idDetalleLlanta, idSucursal, cantidadEntrante, formatForMySql, idTipoMovimiento))
                        {
                            MessageBox.Show("Actualizado correctamente");

                            actualizarTabla();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("no es posible tener stock negativo");
                }
            }
            else
            {
                MessageBox.Show("Se deben completar todos los campos");
            }

            

        }

        private void txtAModificar_KeyPress(object sender, KeyPressEventArgs e)
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
        /* FIN PARTE DE Actualizar*/
        /*-----------------------------------------------------------------------*/


    }
}
