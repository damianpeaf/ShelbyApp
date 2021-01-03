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

namespace Presentacion.App
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string nombreUsuario = info_usuario.nombre;

            lblNombre.Text = nombreUsuario;
        }

        public void AbrirForm2(object hijo)
        {

            if (this.panelFuncion.Controls.Count > 0)
            {
                this.panelFuncion.Controls.RemoveAt(0);
            }

            Form fh = hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.panelFuncion.Controls.Add(fh);
            this.panelFuncion.Tag = fh;
            fh.Show();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        //boton e imagen usuarios
        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirForm2(new Usuarios());

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirForm2(new Usuarios());

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirForm2(new Cuenta());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm2(new Sucursales());
        }

        //FIN boton e imagen usuarios


    }
}
