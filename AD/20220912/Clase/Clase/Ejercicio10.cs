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
using Clase.Resources;

namespace Clase
{
    public partial class Ejercicio10 : Form

    {
        String saludo = "Bienvenida";
        public Ejercicio10()
        {
            InitializeComponent();
            Load();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {}
        private void Form1_Load(object sender, EventArgs e)
        {



        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLenguaje_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-ES");
                MessageBox.Show(saludo);

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                MessageBox.Show(saludo);


            }




            comboBox1.Items.Clear();
            comboBox1.Items.Add(GenericoEspañol.cbEspañol);
            comboBox1.Items.Add(GenericoIngles.cbIngles);
            lblLenguaje.Text = GenericoLenguaje.lblLenguaje;
            btnLenguaje.Text = GenericoBoton.Button;
            MessageBox.Show(GenericoSaludo.Bienvenida);









        }
    }
}
