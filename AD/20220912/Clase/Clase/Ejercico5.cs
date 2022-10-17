using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase
{
    public partial class Ejercico5 : Form
    {
        int num = 20;
        public Ejercico5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox1.Text = num.ToString();
            textBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(label1.Text == "")
            {
                label1.Text = textBox1.Text;
            }

            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e){

        }
    }
}
