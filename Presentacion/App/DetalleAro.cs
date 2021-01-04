﻿using System;
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
    public partial class DetalleAro : Form
    {
        DDetalleAro detalle = new DDetalleAro();

        public DetalleAro()
        {
            InitializeComponent();
            actualizarTabla();

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


                txtListarSeleccionadoId.Text = id;
                txtListarSeleccionadoCodigo.Text = codigo;
                txtListarSeleccionadoMedida.Text = medida;
                txtListarSeleccionadoPcd.Text = pcd;
                txtListarSeleccionadoPcd2.Text = pcd2;
                txtListarSeleccionadoDiseno.Text = diseno;

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

            if (string.IsNullOrEmpty(pcd2))
            {
                pcd2 = "NA";
            }

            //validacion
            if (!string.IsNullOrEmpty(codigo) && !string.IsNullOrEmpty(medida) && !string.IsNullOrEmpty(pcd) && !string.IsNullOrEmpty(pcd2) && !string.IsNullOrEmpty(diseno))
            {


                if (detalle.crearDetalle(codigo, medida, pcd, pcd2, diseno))
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

            if (string.IsNullOrEmpty(pcd2))
            {
                pcd = "NA";
            }

            //validacion
            if (!string.IsNullOrEmpty(codigo) && !string.IsNullOrEmpty(medida) && !string.IsNullOrEmpty(pcd) && !string.IsNullOrEmpty(pcd2) && !string.IsNullOrEmpty(diseno))
            {
                if (detalle.actualizarDetalle(id,codigo, medida, pcd, pcd2,diseno))
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
