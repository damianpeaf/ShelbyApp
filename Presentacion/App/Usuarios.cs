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
    public partial class Usuarios : Form
    {
        DUsuario usuario = new DUsuario();

        public Usuarios()
        {
            InitializeComponent();
            actualizarTabla();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        void actualizarTabla()
        {
            DataSet ds = usuario.listarTodos();
            dataGridView1.DataSource = ds.Tables[0];
        }

        /*-----------------------------------------------------------------------*/
        /*PARTE DE LISTAR*/
        /*-----------------------------------------------------------------------*/

        private void btntListarBuscar_Click(object sender, EventArgs e)
        {
            string idUsuario = txtListarBuscarId.Text;
            string nombreUsuario = txtListarBuscarNombre.Text;
            string correoUsuario = txtListarBuscarCorreo.Text;

            DataSet ds = usuario.buscarUsuario(idUsuario, nombreUsuario, correoUsuario);
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
                string correo = dataGridView1.Rows[n].Cells[2].Value.ToString();

                txtListarSeleccionadoId.Text = id;
                txtListarSeleccionadoNombre.Text = nombre;
                txtListarSeleccionadoCorreo.Text = correo;

                IdSeleccionadaAlListar = id;

            }
        }

        private void btnListarActualizar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            String[] datosUsuario = usuario.cargarDatosUsuario(IdSeleccionadaAlListar);
            if (datosUsuario != null)
            {
                txtActualizarId.Text = datosUsuario[0];
                txtActualizarNombre.Text = datosUsuario[1];
                txtActualizarCorreo.Text = datosUsuario[2];
            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }

        }

        private void btnListarEliminar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            String[] datosUsuario = usuario.cargarDatosUsuario(IdSeleccionadaAlListar);
            if (datosUsuario != null)
            {
                txtEliminarId.Text = datosUsuario[0];
                txtEliminarNombre.Text = datosUsuario[1];
                txtEliminarCorreo.Text = datosUsuario[2];
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
            string correo = txtCrearCorreo.Text;
            string contra = txtCrearContra.Text;
            string confi = txtCrearConfi.Text;


            //validacion
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(correo) && !string.IsNullOrEmpty(contra) && !string.IsNullOrEmpty(confi))
            {

                if (contra == confi)
                {

                    if (usuario.crearUsuario(nombre, correo, contra))
                    {
                        MessageBox.Show("Usuario creado");
                        actualizarTabla();
                         txtCrearNombre.Text="";
                        txtCrearCorreo.Text="";
                       txtCrearContra.Text="";
                        txtCrearConfi.Text="";

                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al crear usuario");

                    }
                }
                else
                {
                    MessageBox.Show("Las contraseña no coinciden");
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

        private void btnActualizarBuscar_Click(object sender, EventArgs e)
        {
            String[] datosUsuario = usuario.cargarDatosUsuario(txtActualizarBuscarId.Text);
            if (datosUsuario != null)
            {
                txtActualizarId.Text = datosUsuario[0];
                txtActualizarNombre.Text = datosUsuario[1];
                txtActualizarCorreo.Text = datosUsuario[2];
            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txtActualizarId.Text;
            string nombre = txtActualizarNombre.Text;
            string correo = txtActualizarCorreo.Text;


            //validacion
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(correo) && !string.IsNullOrEmpty(id))
            {
                if (usuario.actualizarUsuario(id, nombre, correo))
                {
                    MessageBox.Show("Usuario actualizado");
                    actualizarTabla();
                    txtActualizarId.Text="";
                    txtActualizarNombre.Text="";
                    txtActualizarCorreo.Text="";
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar usuario");

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

        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            String[] datosUsuario = usuario.cargarDatosUsuario(txtEliminarBuscarId.Text);
            if (datosUsuario != null)
            {
                txtEliminarId.Text = datosUsuario[0];
                txtEliminarNombre.Text = datosUsuario[1];
                txtEliminarCorreo.Text = datosUsuario[2];
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
                if (usuario.eliminarUsuario(id))
                {
                    MessageBox.Show("Usuario eliminado");
                    actualizarTabla();
                    txtEliminarId.Text="";
                    txtEliminarNombre.Text = "";
                    txtEliminarCorreo.Text = "";
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar usuario");

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
