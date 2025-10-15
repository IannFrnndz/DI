using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_A1._8Simulacro
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedido formPedidos = new FormPedido();
            formPedidos.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarta formCarta = new FormCarta();
            formCarta.ShowDialog();
        }

        private void btnVerCarta_Click(object sender, EventArgs e)
        {
            FormCarta formCarta = new FormCarta();
            formCarta.ShowDialog();
        }

        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            FormPedido formPedidos = new FormPedido();
            formPedidos.ShowDialog();
        }
    }
}
