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

namespace Presentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            RecuperarContra cambio = new RecuperarContra();
            cambio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dlogin login = new Dlogin();
            var validLogin = login.loginpa(textBox1.Text, textBox2.Text);
            if (validLogin == true)
            {
                MessageBox.Show("Bienvenid@");
              

            }
            else
            {
                MessageBox.Show("Correo o Contraseña Incorrectos");
                textBox1.Text = "";
                textBox2.Text = "";
               
            }

        }
    }
}
