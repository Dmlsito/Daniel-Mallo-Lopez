


using System.Drawing.Text;
using System.Globalization;
using Parejas.Properties;

namespace Parejas
{
    public partial class Form1 : Form
    {
       private  String TemporizadorDesactivado = "El temporizador no esta activo";
        private String modoFacil = "facil";
        private String modoDificil = "dificil";
        private String modoNormal = "normal";
        private String advertencia = "El juego no ha comenzado";
        private String terminarJuego = "Se ha terminado el tiempo";
        private String mensajeGanador = "Has ganado el juego";
        private int contador = 0;
        private int temporizador = 100;
        private bool juegoComenzado;
        private bool ciruela1 = false;
        private bool sandia1 = false;
        private bool pera1 = false;
        private bool ciruela2 = false;
        private bool platano1 = false;
        private bool manzana2 = false;
        private bool sandia2 = false;
        private bool platano2 = false;
        private bool manzana1 = false;
        private bool pera2 = false;
        private bool melocoton1 = false;
        private bool naranja2 = false;
        private bool coco1 = false;
        private bool melocoton2 = false;
        private bool granadina1 = false;
        private bool uvas1 = false;
        private bool peladiño1 = false;
        private bool fresas2 = false;
        private bool peladiño2 = false;
        private bool fresas1 = false;
        private bool coco2 = false;
        private bool granadina2 = false;
        private bool naranja1 = false;
        private bool uvas2 = false;


        public Form1()
        {
            InitializeComponent();
         }
        
      

        //Primera fila
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Esta funcion comprobara si el usuario ha pulsado el boton de Start antes de pulsar sobre la imagen, si esto no ocurre saltara un mensaje de advertencia
            if (comprobacionStart())
                {
                    //Reiniciamos el contador para que podamos hacer la comparacion sin arrastrar valores 
                    //El contador equivale al numero de clicks del usuario
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    //Si resulta que el contador impar (esto lo comprueba la funcion), se imprimira la iamgen oculta, si es par se volvera a mostrar la interrogacion
                    if (asignarImagen(contador))
                    {

                        pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Ciruela1.jpg");
                        ciruela1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        ciruela1 = false;
                    }
                //Si el usurio ha encontrado todas las parejas saltara un mensaje
              

               }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

           

            if (comprobacionStart())
            {
                if (contador != 0)
                {
                    contador = 0;

                }
                else if (contador == 0)
                {
                    contador++;
                }
                if (asignarImagen(contador))
                {

                    pictureBox2.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Sandia1.jpg");
                    sandia1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox2.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                    sandia1 = false;
                }

            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";


            }
        }

            private void pictureBox3_Click(object sender, EventArgs e)
        {
          
                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox3.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Pera1.jpg");
                        pera1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox3.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        pera1 = false;
                    }
               
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox4.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Ciruela2.jpg");
                        ciruela2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox4.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        ciruela2 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
          //Esta funcion comprobara si el usuario ha pulsado el boton de Start antes de pulsar sobre la imagen, si esto no ocurre saltara un mensaje de advertencia
                

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox5.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Platano1.jpg");
                        platano1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox5.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        platano1 = false;
                    }
               
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        


        private void pictureBox6_Click(object sender, EventArgs e)
        {
           

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox6.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Manzana2.jpg");
                        manzana2 = true;

                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox6.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        manzana2 = false;
                    }
               
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        //Segunda fila

        private void pictureBox7_Click(object sender, EventArgs e)
        {
          

                if (comprobacionStart())
                {

                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox7.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Sandia2.jfif");
                        sandia2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox7.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        sandia2 = false;
                    }
               
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
              

                if (comprobacionStart())
                {

                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox10.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Platano2.jpg");
                        platano2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox10.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        platano2 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
           

                if (comprobacionStart())
                {

                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox11.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Manzana1.jpg");
                        manzana1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox11.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                       manzana1 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
          

                if (comprobacionStart())
                {

                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox12.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Pera2.jpg");
                        pera2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox12.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        pera2 = false;
                    }
                
                
                }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
          

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox13.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Melocoton1.jpg");
                        melocoton1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox13.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        melocoton1 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
           
               

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox14.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Naranja2.jfif");
                        naranja2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox14.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        naranja2 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        //Tercera fila
        private void pictureBox8_Click(object sender, EventArgs e)
        {
           

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox8.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Coco1.jfif");
                        coco1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox8.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        coco1 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
           

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox15.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Melocoton2.jpg");
                        melocoton2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox15.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        melocoton2 = false;
                    }
               
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
           

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox16.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Granadina1.jpg");
                        granadina1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox16.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        granadina1 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
              
                LblTemporizador.Text = "";

            }

        }
        
        private void pictureBox17_Click(object sender, EventArgs e)
        {
           

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox17.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Uvas1.jpg");
                        uvas1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox17.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        uvas1 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
          

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox18.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Peladiño1.jfif");
                        peladiño1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox18.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        peladiño1 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
          

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox19.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Fresas2.jfif");
                        fresas2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox19.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        fresas2 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
          

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox9.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Peladiño2.jpg");
                        peladiño2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox9.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        peladiño2 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox20.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Fresas1.jfif");
                        fresas1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox20.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        fresas1 = false;
                    }
               
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            
                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox21.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Coco2.jpg");
                        coco2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox21.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        coco2 = false;
                    }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            

                    if (comprobacionStart())
                    {
                        if (contador != 0)
                        {
                            contador = 0;

                        }
                        else if (contador == 0)
                        {
                            contador++;
                        }
                        if (asignarImagen(contador))
                        {

                            pictureBox22.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Granadina2.jfif");
                            granadina2 = true;
                        }
                        else if (!asignarImagen(contador))
                        {
                            pictureBox22.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                            granadina2 = false;
                        }
                
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
          
            

                if (comprobacionStart())
                {
                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox23.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Naranja1.jpg");
                        naranja1 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox23.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        naranja1 = false;
                    }
               
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
           

                if (comprobacionStart())
                {

                    if (contador != 0)
                    {
                        contador = 0;

                    }
                    else if (contador == 0)
                    {
                        contador++;
                    }
                    if (asignarImagen(contador))
                    {

                        pictureBox24.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Uvas2.jpeg");
                        uvas2 = true;
                    }
                    else if (!asignarImagen(contador))
                    {
                        pictureBox24.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                        uvas2 = false;
                    }
               
            }
            if (ganador())
            {

                MessageBox.Show(mensajeGanador);
                Temporizador.Enabled = false;
                LblTemporizador.Text = "";

            }

        }
        private void ComboBoxLenguajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ya que al hacer el clear del ComboBox y añadir de nuevo los idiomas, estos se ordenaran de forma alfabetica, posicionandose English en la posicion 0, en propiedades
            //tenemos que poner a false la propiedad sorted

            if (ComboBoxLenguajes.SelectedIndex == 0)

            {

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-ES");
                MessageBox.Show("Idioma escogido: Español");
                ComboBoxLenguajes.Items.Clear();
                comboBoxDificultad.Items.Clear();

                generarElementosEspañol();


            }
            else if (ComboBoxLenguajes.SelectedIndex == 1 )
            {

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                MessageBox.Show("Idioma escogido: Inglés");
                ComboBoxLenguajes.Items.Clear();
                comboBoxDificultad.Items.Clear();


                generarElementosIngles();
              
            }
        }

        private void generarElementosEspañol()
        {
            ComboBoxLenguajes.Items.Add(GenericoCbbItem3.CbbEspanishToEspañol);
            ComboBoxLenguajes.Items.Add(GenericoCbbItem4.CbbEnglishToIngles);
            labelJugador.Text = GenericoLabelEspañol.lblJugadorToEspañol;
            labelLenguaje.Text = GenericoLabeldiomaEspañol.IdiomaEspañol;
            BtnStart.Text = GenericoButtonEspañol.ButtonEspañol;
            terminarJuego = GenericoDespedidaEspañol.DespedidaEspañol;
            advertencia = GenericoAdvertenciaEspañol.AdvertenciaEspañol;
            comboBoxDificultad.Items.Add(GenericoFacilEspañol.FacilEspañol);
            comboBoxDificultad.Items.Add(GenericoNormalEspañol.NormalEspañol);
            comboBoxDificultad.Items.Add(GenericoDificilEspañol.DificilEspañol);
            labelDificultad.Text = GenericoLabelDificultadEspañol.LabelDificultadEspañol;
            TemporizadorDesactivado = GenericoTemporizadorDesactivadoEspañol.MensajeTemporizadorEspañol;

        }

        private void generarElementosIngles()
        {
            labelJugador.Text = GenericoJugador.LabelJugador;
            BtnStart.Text = GenericoStartButton.BtnStart;
            labelLenguaje.Text = GenericoLabelIdioma.LabelIdioma;
            ComboBoxLenguajes.Items.Add(GenericoCbbItem1.CbbEspañolToSpanish);
            ComboBoxLenguajes.Items.Add(GenericoCbbItem2.CbbInglesToEnglish);
            terminarJuego = GenericoDespedidaIngles.DespedidaIngles;
            advertencia = GenericoAdvertenciaIngles.AvertenciaIngles;
            comboBoxDificultad.Items.Add(GenericoFacilIngles.FacilIngles);
            comboBoxDificultad.Items.Add(GenericoNormalIngles.NormalIngles);
            comboBoxDificultad.Items.Add(GenericoDificilIngles.DificilIngles);
            labelDificultad.Text = GenericoLabelDificultad.LabelDificultad;
            TemporizadorDesactivado = GenericoTemporizadorDesactivadoIngles.MensajeTemporizadorIngles;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //Cuando el juego comience inicializamos juegoComenzado a true, como indicacion de que empieza el juego
            juegoComenzado = true;
            //Cuando el usuario le de a empezar aplicamos el selector de dificultad;
            selectorDificultad();
            ajustarDificultad();

           
            Temporizador.Enabled = true;
        }

        

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            temporizador--;
            LblTemporizador.Text = temporizador.ToString();

            
          

            //Reiniciamos el juego
            reiniciarJuego();
        }


        private bool asignarImagen(int contador)
        {

            if (contador % 2 != 0)
            {
                return false;
            }

            return true;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Garantizamos que se detenga el temporizador
            Temporizador.Enabled = false;
        }

        private String selectorDificultad()
        {
            if(comboBoxDificultad.SelectedIndex == 0)
            {
                return modoFacil;
            }
            else if(comboBoxDificultad.SelectedIndex == 1)
            {
                return modoNormal;
            }
            return modoDificil;
        }

       private void ajustarDificultad()
        {
            if (selectorDificultad().Equals("facil"))
            {
                Temporizador.Interval = 1000;
                //Despues de que se hayan realizados los cambios del Timer, si el usuario quiere jugar una segunda vez reiniciaremos la variable temporizador,
                //dependiendo de la dificultad escogida.
                if(temporizador != 100)
                {
                    temporizador = 100;
                }
            }else if (selectorDificultad().Equals("normal"))
            {
                Temporizador.Interval = 500;
                if (temporizador != 50)
                {
                    temporizador = 50;
                }
            }
            else if (selectorDificultad().Equals("dificil"))
            {
                Temporizador.Interval = 250;
                if (temporizador != 25)
                {
                    temporizador = 25;
                }
            }
        }
        
        private bool comprobacionStart()
        {
            if (!juegoComenzado)
            {
                MessageBox.Show(advertencia);
                return false;
            }
            return true;
        }

        private void reiniciarJuego()
        {
            if (temporizador == 0)
            {
                juegoComenzado = false;
                Temporizador.Enabled = false;
                MessageBox.Show(terminarJuego);

                //Indicamos tambien que se reinicien todas las imagenes 
                pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox2.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox3.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox4.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox5.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox6.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox7.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox8.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox9.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox10.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox11.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox12.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox13.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox14.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox15.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox16.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox17.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox18.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox19.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox20.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox21.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox22.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox23.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox24.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
            
            }else if (ganador())
            {

                  ciruela1 = false;
                 sandia1 = false;
          pera1 = false;
        ciruela2 = false;
        platano1 = false;
        manzana2 = false;
      sandia2 = false;
       platano2 = false;
         manzana1 = false;
        pera2 = false;
        melocoton1 = false;
        naranja2 = false;
         coco1 = false;
        melocoton2 = false;
         granadina1 = false;
        uvas1 = false;
         peladiño1 = false;
         fresas2 = false;
         peladiño2 = false;
        fresas1 = false;
        coco2 = false;
         granadina2 = false;
         naranja1 = false;
         uvas2 = false;
        pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox2.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox3.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox4.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox5.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox6.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox7.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox8.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox9.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox10.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox11.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox12.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox13.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox14.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox15.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox16.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox17.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox18.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox19.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox20.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox21.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox22.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox23.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                pictureBox24.Image = System.Drawing.Image.FromFile("C:\\Users\\usuario\\Documents\\GitHub\\Daniel-Mallo-Lopez\\DesarroloDeInterfaces\\2022-2023\\Parejas\\Parejas\\Properties\\Prueba2.png");
                
            }
        }

        private bool ganador() {
            
            if (ciruela1 == true && ciruela2 == true && sandia1 == true && sandia2 == true && pera1 == true && pera2 == true && platano1 == true && platano2 == true && manzana1 == true && manzana2 == true
                && melocoton1 == true && melocoton2 == true && naranja1 == true && naranja2 == true && coco1 == true && coco2 == true && granadina1 == true && granadina2 == true && uvas1 == true && uvas2 == true 
                && fresas1 == true && fresas2 == true && peladiño1 == true && peladiño2 == true) {
                
                
                return true;
                
               }
            return false;
         
        
        }
    }
}