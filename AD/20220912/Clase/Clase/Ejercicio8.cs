using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase
{
    public partial class Ejercicio8 : Form
    {
        
        TextBox textBox = new TextBox();

        public Ejercicio8()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {

            crearLabel();
            crearTextBox();
       
          

           
            

        }

        public void crearLabel()
        {
            Label Name = new Label();
            Name.Text = "Name";
            Name.Location = new Point(12, 45);
            Name.Font = new Font("Arial", 20);
            Name.Show();
            this.Controls.Add(Name);
        }

        public void crearTextBox()
        {
            TextBox textBox = new TextBox();
            textBox.Location = new Point(120, 52);
            textBox.Size = new Size(150, 40);
            textBox.MaxLength = 40;
            this.Controls.Add(textBox);
        }

        /*public void crearBoton()
        {
            Button Saludo = new Button();
            Saludo.Text = "Saludo";
            Saludo.Location = new Point(20, 100);
            Saludo.Size = new Size(80, 30);
            Saludo.BackColor = Color.AliceBlue;
            Saludo.Click += new EventHandler(Saludar);
            this.Controls.Add(Saludo);

        }*/
        


    }
}
