using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new FParte1();
            formulario.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new FParte2();
            formulario.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new FParte3();
            formulario.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new FParte4();
            formulario.ShowDialog();
        }
    }
}
