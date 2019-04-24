using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_3_evaluacion
{
    public partial class pgb1 : Form
    {
        public pgb1()
        {
            InitializeComponent();
             
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "javier" && textBox2.Text == "mendez")
            {
                MDIParent1 nmdi = new MDIParent1();
                nmdi.Show();

            }
            else
            { 
            MessageBox.Show("Usuario o contraseña incorrecto");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
