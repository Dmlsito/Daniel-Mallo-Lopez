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
    
    public partial class Formulario : Form
    {
       
        public Formulario()
        {
            InitializeComponent();
            load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void label1_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1 ejercicio1 = new Ejercicio1();

            ejercicio1.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();
            ejercicio2.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ejercicio3 formulario = new Ejercicio3();
            formulario.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ejercicio4 formulario = new Ejercicio4();
            formulario.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "hola";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ejercico5 formulario = new Ejercico5();
            formulario.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ejercicio7 formulario = new Ejercicio7();
            formulario.ShowDialog();

        }
    }
}
