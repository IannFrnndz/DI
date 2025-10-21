using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AE1_DI_IanFernandezGamo
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private String mensaje;

        public String Mensaje
        {
            get { return mensaje; }
            set
            {
                mensaje = value;
                label1.Text = mensaje;
                
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
