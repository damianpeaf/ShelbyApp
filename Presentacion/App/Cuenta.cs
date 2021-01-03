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
    public partial class Cuenta : Form
    {
        DUsuario usuario = new DUsuario();

        public Cuenta()
        {
            InitializeComponent();

            String[] datosUsuario = usuario.cargarDatosUsuario(info_usuario.idUsuario);

            txtId.Text = datosUsuario[0];
            txtNombre.Text = datosUsuario[1];
            txtCorreo.Text = datosUsuario[2];
            txtContra.Text = datosUsuario[3];

        }

        private void checkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNombre.Checked == true)
            {
                txtNombre.ReadOnly = false;
            }
            else
            {
                txtNombre.ReadOnly = true;
            }
        }

        private void checkCorreo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCorreo.Checked == true)
            {
                txtCorreo.ReadOnly = false;
            }
            else
            {
                txtCorreo.ReadOnly = true;
            }
        }

        private void checkContra_CheckedChanged(object sender, EventArgs e)
        {
            if (checkContra.Checked == true)
            {
                txtContra.ReadOnly = false;
                txtConfi.ReadOnly = false;

            }
            else
            {
                txtContra.ReadOnly = true;
                txtConfi.ReadOnly = true;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre;
            string correo;
            string contra;
            string confi;

            bool cambioContrasena = false;
            bool iguales = false;


            //validacion nombre
            if (checkNombre.Checked == true)
            {

                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    nombre = txtNombre.Text;
                }
                else
                {
                    nombre = null;
                }
            }
            else
            {
                nombre = "";

            }

            //validacion correo
            if (checkCorreo.Checked == true)
            {

                if (!string.IsNullOrEmpty(txtCorreo.Text))
                {
                    correo = txtCorreo.Text;

                }
                else
                {
                    correo = null;
                }
            }
            else
            {
                correo = "";

            }

            //validacion contrasena
            if (checkContra.Checked == true)
            {

                if (!string.IsNullOrEmpty(txtContra.Text))
                {
                    contra = txtContra.Text;
                }
                else
                {
                    contra = null;
                }
                
                if (!string.IsNullOrEmpty(txtConfi.Text))
                {
                    confi = txtConfi.Text;
                }
                else
                {
                    confi = null;
                }

                if (!string.IsNullOrEmpty(txtContra.Text) && !string.IsNullOrEmpty(txtConfi.Text))
                {
                    cambioContrasena = true;

                    if (cambioContrasena)
                    {
                        if (contra == confi)
                        {
                            iguales = true;
                        }
                    }
                }

                
            }
            else
            {
                contra = "";
                confi = "";
            }


            //codigo para llamar al metodo

            if ((cambioContrasena == true && iguales == true) || (cambioContrasena == false && iguales == false))
            {
                if (nombre == null || correo == null || contra == null || confi == null)
                {
                    MessageBox.Show("Debe llenar todos los campos a actualizar");
                }
                else
                {
                    if(usuario.actualizarDatosUsuario(id, nombre, correo, contra))
                    {
                        MessageBox.Show("Actualizado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("No se ha realizado ningun cambio");

                    }
                }

            }
            else
            {
                MessageBox.Show("Las contraseñas deben ser iguales");
            }

        }
    }
}
