using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AE1_DI_IanFernandezGamo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDestinos formDestino = new FormDestinos();
            formDestino.ShowDialog();
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOfertas formOfertas = new FormOfertas();
            formOfertas.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservas formReservas = new FormReservas();
            formReservas.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
