using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsEx
{
    public partial class FParte4 : Form
    {

        String despedida = "Adios";
        public FParte4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                idiomaEspañol();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                idiomaIngles();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            if(comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show(despedida + " Tatiana");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                MessageBox.Show(despedida + " Paco");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                MessageBox.Show(despedida + " Marta");
            }
            if (comboBox1.SelectedIndex == 3)
            {
                MessageBox.Show(despedida + " Lois");
            }

        }

        private void idiomaEspañol()
        {
            CultureInfo español = new CultureInfo("es-Es");
            Thread.CurrentThread.CurrentCulture = español;

            button1.Text = Properties.GenericoTextButtonEspañol.Acceder;
            checkBox1.Text = Properties.GenericoTextCheck1Español.Castellano;
            checkBox2.Text = Properties.GenericoTextCheck2.Ingles;
            despedida = Properties.GenericoDespedidaEspañol.Despedida;

                
        
        }
        private void idiomaIngles()
        {
            CultureInfo ingles = new CultureInfo("en-Us");
            Thread.CurrentThread.CurrentCulture = ingles;
            
            button1.Text = Properties.GenericoTextButtonIngles.Go;
            checkBox1.Text = Properties.GenericoTextCheck1Ingles.Spanish;
            checkBox2.Text = Properties.GenericoTextCheck2Ingles.English;
            despedida = Properties.GenericoDespedidaIngles.Despedida;

        }


    }
}
