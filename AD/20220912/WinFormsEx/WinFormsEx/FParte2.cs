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
    public partial class FParte2 : Form
    {

        BindingList<Usuario> listaUsuarios = new BindingList<Usuario>();
        ErrorProvider errorProviderNombre = new ErrorProvider();
        ErrorProvider errorProviderEdad = new ErrorProvider();

        bool errorEnNombre = false;
        bool errorEnEdad = false;
        public FParte2()
        {
            InitializeComponent();
            dataGridView1.DataSource = listaUsuarios;
        }



        private void añadirUsuario()
        {

            if (!errorEnEdad && !errorEnNombre)
            {
                //Creamos el nuevo usuario, le damos sus valores y lo añadimos a la lista 
                listaUsuarios.Add(new Usuario
                {
                    nombre = textBoxNombre.Text,
                    edad = Int32.Parse(textBoxEdad.Text),
                });
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEdad.Text, "^[0-9]"))
            {
                errorProviderEdad.SetError(textBoxNombre, "Solo numeros");
                errorEnEdad = true;
            }
            else
            {
                errorProviderEdad.SetError(textBoxNombre, "");
                errorEnEdad = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            añadirUsuario();   
        }
    }
}
