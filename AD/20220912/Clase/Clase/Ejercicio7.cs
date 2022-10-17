using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clase
{

    public partial class Ejercicio7 : Form
    {
        BindingList<Alumno> listado = new BindingList<Alumno>();
        public Ejercicio7()
        {
            InitializeComponent();
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Ejercicio7_Load(object sender, EventArgs e)
        {
            listado.Add(new Alumno
            {
                Nombre = "Pedro",
                Edad = 32,
                Alta = DateTime.Parse("5/12/2018"),
                Comedor = true,
                Turno = "Mañana"
            });


            dataGridView1.DataSource = listado;
        }


        private void BttAgregar_Click(object sender, EventArgs e)
        {
            Alumno nuevoAlumno = new Alumno
            {
                Nombre = tbNombre.Text,
                Edad = Int32.Parse(textBox2.Text),
                Alta = dtAlta.Value.Date,
                Comedor = ckbComedor.Checked,
                Turno = cbTurno.Text,
            };

            listado.Add(nuevoAlumno);
           




        }





    }
}
    

