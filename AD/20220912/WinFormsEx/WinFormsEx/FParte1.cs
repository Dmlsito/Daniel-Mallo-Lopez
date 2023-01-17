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
    public partial class FParte1 : Form
    {

        int contador = 0;
        bool incrementar = false;
        bool decrementar = false;
        public FParte1()
        {
            InitializeComponent();
            //Metodo para que nada mas se abra el formulario empiece a funcionar el timer
            iniciarTemporizador();
           
        }
        private void iniciarTemporizador()
        {
            timer1.Enabled = true;
            timer1.Start();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            labelNumero.Text = contador.ToString();
            //Condicion de inicion de incremento del timer
           if(incrementar == false && decrementar == false)
            {
                contador++;
            }
            if (decrementar)
            {
                contador--;
            }

            if (incrementar)
            {
                contador++;
            }
            
           
        }

        private void buttonIncrementar_Click(object sender, EventArgs e)
        {
            incrementar = true;
            decrementar = false;
        }

        private void buttonDecrementar_Click(object sender, EventArgs e)
        {
            incrementar = false;
            decrementar = true;
        }
    }
}
