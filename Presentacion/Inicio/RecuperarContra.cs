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
    public partial class RecuperarContra : Form
    {
        public RecuperarContra()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login cambio = new login();
            cambio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Dlogin login = new Dlogin();
                string mesa = login.recuperarcontra(textBox1.Text);
                System.Windows.Forms.MessageBox.Show(mesa);
               
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                textBox1.Text = "";

            }
        }
    }
}
