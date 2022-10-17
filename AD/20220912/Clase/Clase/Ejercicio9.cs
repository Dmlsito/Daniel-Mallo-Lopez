using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Clase
{
    public partial class Ejercicio9 : Form
    {
        int contador = 0;
        TextBox email = new TextBox();
        TextBox nombre = new TextBox();
        TextBox telefono = new TextBox();
        ErrorProvider errorProvider = new System.Windows.Forms.ErrorProvider();
        public Ejercicio9()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            labelNombre();
            labelTelefono();
            labelEmail();
            textBoxNombre();
            textBoxTelefono();
            textBoxEmail();
            button();
            

        }


        private void labelNombre()
        {
            Label nombrelabel = new Label();
            nombrelabel.Text = "Nombre";
            nombrelabel.Location = new Point(10, 40);
            nombrelabel.Font = new Font("Arial", 16);
            this.Controls.Add(nombrelabel);


        }
        private void labelTelefono()
        {
            Label telefonolabel = new Label();
            telefonolabel.Text = "Teléfono";
            telefonolabel.Location = new Point(10, 80);
            telefonolabel.Font = new Font("Arial", 16);
            this.Controls.Add(telefonolabel);

        }
        private void labelEmail()
        {
            Label emailLabel = new Label();
            emailLabel.Text = "Email";
            emailLabel.Location = new Point(10, 120);
            emailLabel.Font = new Font("Arial", 16);
            this.Controls.Add(emailLabel);

        }


        private void textBoxNombre()
        {
            
            nombre.Location = new Point(120, 45);
            this.Controls.Add(nombre);

        }
        private void textBoxTelefono()
        {
           
            telefono.Location = new Point(120, 85);
            this.Controls.Add(telefono);

        }
        private void textBoxEmail()
        {
           
            email.Location = new Point(120, 125);
            this.Controls.Add(email);
           

        }

        private void button()
        {

            Button boton = new Button();
            boton.Location = new Point(180, 180);
            boton.Text = "Boton error";
            boton.Click += new EventHandler(Validated);
            this.Controls.Add(boton);
        }

        private void Validated(object sender, EventArgs e) {


            if (nombre.Text != nombre.Text.ToUpper())
            {

                errorProvider.SetError(nombre, "Error 1");
               
            }
            if (!telefonoValidacion())
            {

                errorProvider.SetError(nombre, "Error 2");
            }
            
            //Recogemos del texto de la TextBox en una variable correo
            String correo = email.Text;

            //Recorremos el String con un for para comprobar si se repite el @
            try
            {
                for (int i = 0; i < correo.Length; i++)
                {

                    if (correo.Contains("@"))
                    {
                        contador++;
                    }
                }
            }catch(System.NullReferenceException )
            {}
            
            //Si el contador es mayor o igual que 2 significa que se ha repetido mas de una vez la @
            if (contador != 1) {
                errorProvider.SetError(email, "Error 3");
            }
        }

        private bool telefonoValidacion()
        {
            try {
                 Int32.Parse(telefono.Text);

            }
            catch (Exception e)
            {
                return false;
            }
            return true;





        }


        }
}

