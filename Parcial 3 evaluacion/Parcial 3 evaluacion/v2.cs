using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bclass;

namespace Parcial_3_evaluacion
{
    public partial class v2 : Form
    {
        public v2()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            radioButton1.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 ob=new Class1();
            if (radioButton1.Checked == true)
            {
                txttotal.Text = Convert.ToString((ob.Porcentaje((Convert.ToDouble(textBox1.Text)), Convert.ToDouble(textBox2.Text))));
            }
            else {
                txttotal.Text = textBox1.Text;
            }
            
        }
    }
}
