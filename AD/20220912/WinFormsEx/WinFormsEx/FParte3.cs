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
    public partial class FParte3 : Form
    {
        public FParte3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Se selecciona el radioButton Azul
            if(listBox1.SelectedIndex == 0) {
                radioButton1.Checked = true;
                trackBar1.Value++;

            }
            //Se selecciona el radioButtno rojo
            if (listBox1.SelectedIndex == 1)
            {
                radioButton2.Checked = true;

            }
            //Se selecciona el radioButtno verde
            if (listBox1.SelectedIndex == 2)
            {
                radioButton3.Checked = true;

            }

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                listBox1.SelectedIndex = 0;
            }
          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                listBox1.SelectedIndex = 1;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                listBox1.SelectedIndex = 2;
            }
        }
    }
}
