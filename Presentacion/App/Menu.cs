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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AbrirForm2(new Sucursales());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm2(new DetalleAro(this));

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AbrirForm2(new DetalleAro(this));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirForm2(new Aro(null));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm2(new Aro(null));

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AbrirForm2(new Aro(null));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirForm2(new DetalleLlanta());

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AbrirForm2(new DetalleLlanta());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirForm2(new Movimientos());
        }


        //FIN boton e imagen usuarios


    }
}
