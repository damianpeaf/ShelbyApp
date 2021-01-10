using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.App
{
    public partial class ReportesInventario : Form
    {
        public ReportesInventario()
        {
            InitializeComponent();
        }

        public void AbrirForm2(object hijo)
        {

            if (this.panel2.Controls.Count > 0)
            {
                this.panel2.Controls.RemoveAt(0);
            }

            Form fh = hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();

        }

        private void ReportesInventario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm2(new InventarioAros());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm2(new InventarioLlantas());
        }
    }
}
