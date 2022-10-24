


using System.Drawing.Text;
using System.Globalization;
using Parejas.Properties;

namespace Parejas
{
    public partial class Form1 : Form
    {
        //Error para el textBox de nombreJugador
        ErrorProvider errorTextBoxJugador = new System.Windows.Forms.ErrorProvider();
        //Error para el comoboBox de dificultad
        ErrorProvider errorComboBoxDificultad = new System.Windows.Forms.ErrorProvider();

        private String parejaEncontrada = "Has encontrado una pareja";
        private String TemporizadorDesactivado = "El temporizador no esta activo";
        private String modoFacil = "facil";
        private String modoDificil = "dificil";
        private String modoNormal = "normal";
        private String advertencia = "El juego no ha comenzado";
        private String terminarJuego = "Se ha terminado el tiempo";
        private String mensajeGanador = "Has ganado el juego";
        private String errorTextBox = "Nombre necesario";
        private String errorComboBoxDifi = "Tienes que elegir una dificultad";
        private String errorComboBoxLengua = "Tienes que elegir un lenguaje";

        private int contador = 0;
        private int contadorTiempoImagen = 1;
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
            
                contadorTiempoImagen = 2;
            
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

                    pictureBox1.Image = Resources.Ciruela1;
                    ciruela1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox1.Image = Resources.Prueba2;
                    ciruela1 = false;
                }
            }
            //Con este metodo comprobamos si hemos descubierto alguna de las parejas
            if (comprobarParejaCiruela())
            {
                MessageBox.Show(parejaEncontrada);
                TemporizadorImagen.Enabled = false;
                //Cuando una pareja es encontrada se desactivara su pictureBox 
                pictureBox1.Enabled = false;
                pictureBox4.Enabled = false;
            }
            else
            {
                // Si no es una pareja activamos el tiempo de vida de la imagen
                TemporizadorImagen.Enabled = true;
            }
            //Llamamos a la funcion ganador, para comprobar si el usuario ha ganado
            ganador();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            

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

                    pictureBox2.Image = Resources.Sandia1;
                    sandia1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox2.Image = Resources.Prueba2;
                    sandia1 = false;
                }

            }
            if (comprobarParejaSandia())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox2.Enabled = false;
                pictureBox7.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
                contadorTiempoImagen = 2;
            
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

                    pictureBox3.Image = Resources.Pera1;
                    pera1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox3.Image = Resources.Prueba2;
                    pera1 = false;
                }
            }
            if (comprobarParejaPera())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox3.Enabled = false;
                pictureBox12.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            
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

                    pictureBox4.Image = Resources.Ciruela2;
                    ciruela2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox4.Image = Resources.Prueba2;
                    ciruela2 = false;
                }
            }
            if (comprobarParejaCiruela())
            {
                MessageBox.Show(parejaEncontrada);
                TemporizadorImagen.Enabled = false;
                pictureBox1.Enabled = false;
                pictureBox4.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
             contadorTiempoImagen = 2;
            
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
                    pictureBox5.Image = Resources.Platano1;
                    platano1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox5.Image = Resources.Prueba2;
                    platano1 = false;
                }
            }

            if (comprobarParejaPlatano())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox5.Enabled = false;
                pictureBox10.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            
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
                    pictureBox6.Image = Resources.Manzana2;
                    manzana2 = true;

                }
                else if (!asignarImagen(contador))
                {
                    pictureBox6.Image = Resources.Prueba2;
                    manzana2 = false;
                }
            }
            if (comprobarParejaManzana())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox6.Enabled = false;
                pictureBox11.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        //Segunda fila
        private void pictureBox7_Click(object sender, EventArgs e)
        {
              contadorTiempoImagen = 2;
            
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
                    pictureBox7.Image = Resources.Sandia2;
                    sandia2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox7.Image = Resources.Prueba2;
                    sandia2 = false;
                }
            }
            if (comprobarParejaSandia())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox2.Enabled = false;
                pictureBox7.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();

        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            
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
                    pictureBox10.Image = Resources.Platano2;
                    platano2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox10.Image = Resources.Prueba2;
                    platano2 = false;
                }
            }
            if (comprobarParejaPlatano())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox5.Enabled = false;
                pictureBox10.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
                contadorTiempoImagen = 2;
            
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
                    pictureBox11.Image = Resources.Manzana1;
                    manzana1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox11.Image = Resources.Prueba2;
                    manzana1 = false;
                }
            }
            if (comprobarParejaManzana())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox6.Enabled = false;
                pictureBox11.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
           contadorTiempoImagen = 2;
            
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
                    pictureBox12.Image = Resources.Pera2;
                    pera2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox12.Image = Resources.Prueba2;
                }
            }
            if (comprobarParejaPera())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox3.Enabled = false;
                pictureBox12.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            
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
                    pictureBox13.Image = Resources.Melocoton1;
                    melocoton1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox13.Image = Resources.Prueba2;
                    melocoton1 = false;
                }
            }
            if (comprobarParejaMelocoton())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox13.Enabled = false;
                pictureBox15.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
              contadorTiempoImagen = 2;
            
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
                    pictureBox14.Image = Resources.Naranja2;
                    naranja2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox14.Image = Resources.Prueba2;
                    naranja2 = false;
                }
            }
            if (comprobarParejaNaranja())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox14.Enabled = false;
                pictureBox23.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        //Tercera fila
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            
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
                    pictureBox8.Image = Resources.Coco1;
                    coco1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox8.Image = Resources.Prueba2;
                    coco1 = false;
                }
            }
            if (comprobarParejaCoco())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox8.Enabled = false;
                pictureBox21.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            
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
                    pictureBox15.Image = Resources.Melocoton2;
                    melocoton2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox15.Image = Resources.Prueba2;
                    melocoton2 = false;
                }
            }
            if (comprobarParejaMelocoton())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox13.Enabled = false;
                pictureBox15.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
              contadorTiempoImagen = 2;
            
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
                    pictureBox16.Image = Resources.Granadina1;
                    granadina1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox16.Image = Resources.Prueba2;
                    granadina1 = false;
                }
            }
            if (comprobarParejaGranadina())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox16.Enabled = false;
                pictureBox22.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            
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
                    pictureBox17.Image = Resources.Uvas1;
                    uvas1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox17.Image = Resources.Prueba2;
                    uvas1 = false;
                }
            }
            if (comprobarParejaUvas())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox17.Enabled = false;
                pictureBox24.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
                contadorTiempoImagen = 2;
            
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
                    pictureBox18.Image = Resources.Peladiño1;
                    peladiño1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox18.Image = Resources.Prueba2;
                    peladiño1 = false;
                }
            }
            if (comprobarParejaPeladiño())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox18.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox19_Click(object sender, EventArgs e)
        {
           
                contadorTiempoImagen = 2;
            
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
                    pictureBox19.Image = Resources.Fresas2;
                    fresas2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox19.Image = Resources.Prueba2;
                    fresas2 = false;
                }
            }
            if (comprobarParejaFresa())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox19.Enabled = false;
                pictureBox20.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
          
                contadorTiempoImagen = 2;
            
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
                    pictureBox9.Image = Resources.Peladiño2;
                    peladiño2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox9.Image = Resources.Prueba2;
                    peladiño2 = false;
                }
            }
            if (comprobarParejaPeladiño())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox18.Enabled = false;
                pictureBox9.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            
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
                    pictureBox20.Image = Resources.Fresas1;
                    fresas1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox20.Image = Resources.Prueba2;
                    fresas1 = false;
                }
            }
            if (comprobarParejaFresa())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox19.Enabled = false;
                pictureBox20.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox21_Click(object sender, EventArgs e)
        {
           
                contadorTiempoImagen = 2;
            
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
                    pictureBox21.Image = Resources.Coco2;
                    coco2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox21.Image = Resources.Prueba2;
                    coco2 = false;
                }
            }
            if (comprobarParejaCoco())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox8.Enabled = false;
                pictureBox21.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox22_Click(object sender, EventArgs e)
        {
           
                contadorTiempoImagen = 2;
            
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
                    pictureBox22.Image = Resources.Granadina2;
                    granadina2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox22.Image = Resources.Prueba2;
                    granadina2 = false;
                }
            }
            if (comprobarParejaGranadina())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox16.Enabled = false;
                pictureBox22.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            
                contadorTiempoImagen = 2;
            
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
                    pictureBox23.Image = Resources.Naranja1;
                    naranja1 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox23.Image = Resources.Prueba2;
                    naranja1 = false;
                }
            }
            if (comprobarParejaNaranja())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox14.Enabled = false;
                pictureBox23.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void pictureBox24_Click(object sender, EventArgs e)
        {
          
                contadorTiempoImagen = 2;
            
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
                    pictureBox24.Image = Resources.Uvas2;
                    uvas2 = true;
                }
                else if (!asignarImagen(contador))
                {
                    pictureBox24.Image = Resources.Prueba2;
                    uvas2 = false;
                }
            }
            if (comprobarParejaUvas())
            {
                MessageBox.Show(parejaEncontrada);
                pictureBox17.Enabled = false;
                pictureBox24.Enabled = false;
            }
            else
            {
                TemporizadorImagen.Enabled = true;
            }
            ganador();
        }
        private void ComboBoxLenguajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ya que al hacer el clear del ComboBox y añadir de nuevo los idiomas, estos se ordenaran de forma alfabetica, posicionandose English en la posicion 0, en propiedades
            //tenemos que poner a false la propiedad sorted
            if (ComboBoxLenguajes.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-ES");
                MessageBox.Show("Idioma escogido: Español");
                //Hacemos un clear en todos los comboBoxs para que los items no se acumulen
                ComboBoxLenguajes.Items.Clear();
                comboBoxDificultad.Items.Clear();

                generarElementosEspañol();
            }
            else if (ComboBoxLenguajes.SelectedIndex == 1)
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
            parejaEncontrada = GenericoEspañol.ParejaEncontradaEspañol;
            errorTextBox = GenericoErrorTextoEspañol.TextoErrorEs;
            errorComboBoxDifi = GenericoErrorComboDifiEs.ErrorEs;
           
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
            parejaEncontrada = GenericoIngles.ParejaEncontradaIngles;
            errorComboBoxDifi = GenericoErrorComboDifiIn.ErrorIn;
            errorTextBox = GenericoErrorTexto.ErrorTexto;
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!Comprobar())
            { }
            else
            {
                //Desactivamos los errores
                errorTextBoxJugador.Clear();
                errorComboBoxDificultad.Clear();
                //Cuando el juego comience inicializamos juegoComenzado a true, como indicacion de que empieza el juego
                juegoComenzado = true;
                //Cuando el usuario le de a empezar aplicamos el selector de dificultad;
                selectorDificultad();
                ajustarDificultad();
                //Activamos el temporizador
                Temporizador.Enabled = true;
            }
        }
        //Esta funcio controlara que el usuario ha introducido un nombre y ha elegio dificultad
        private bool  Comprobar()
        {
            if (textBox1.Text == "")
            {
                errorTextBoxJugador.SetError(this.textBox1, errorTextBox);
                return false;
            }else if(comboBoxDificultad.Text == "")
            {
                errorComboBoxDificultad.SetError(this.comboBoxDificultad, errorComboBoxDifi);
                return false;
            }
            return true;
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
            if (comboBoxDificultad.SelectedIndex == 0)
            {
                return modoFacil;
            }
            else if (comboBoxDificultad.SelectedIndex == 1)
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
                if (temporizador != 200)
                {
                    temporizador = 200;
                }
            }
            else if (selectorDificultad().Equals("normal"))
            {
                Temporizador.Interval = 1000;
                if (temporizador != 100)
                {
                    temporizador = 100;
                }
            }
            else if (selectorDificultad().Equals("dificil"))
            {
                Temporizador.Interval = 1000;
                if (temporizador != 50)
                {
                    temporizador = 50;
                }
            }
        }
        //Esta funcion controlara que se haya pulsado el boton de comenzar para empezar el juego
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
                LblTemporizador.Text = "";
                juegoComenzado = false;
                Temporizador.Enabled = false;
                MessageBox.Show(terminarJuego);

                //Indicamos que se reinicien todas las imagenes 
                pictureBox1.Image = Resources.Prueba2;
                pictureBox2.Image = Resources.Prueba2;
                pictureBox3.Image = Resources.Prueba2;
                pictureBox4.Image = Resources.Prueba2;
                pictureBox5.Image = Resources.Prueba2;
                pictureBox6.Image = Resources.Prueba2;
                pictureBox7.Image = Resources.Prueba2;
                pictureBox8.Image = Resources.Prueba2;
                pictureBox9.Image = Resources.Prueba2;
                pictureBox10.Image = Resources.Prueba2;
                pictureBox11.Image = Resources.Prueba2;
                pictureBox12.Image = Resources.Prueba2;
                pictureBox13.Image = Resources.Prueba2;
                pictureBox14.Image = Resources.Prueba2;
                pictureBox15.Image = Resources.Prueba2;
                pictureBox16.Image = Resources.Prueba2;
                pictureBox17.Image = Resources.Prueba2;
                pictureBox18.Image = Resources.Prueba2;
                pictureBox19.Image = Resources.Prueba2;
                pictureBox20.Image = Resources.Prueba2;
                pictureBox21.Image = Resources.Prueba2;
                pictureBox22.Image = Resources.Prueba2;
                pictureBox23.Image = Resources.Prueba2;
                pictureBox24.Image = Resources.Prueba2;

                //Indicamos que todas las imagenes esten activadas
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
                pictureBox13.Enabled = true;
                pictureBox14.Enabled = true;
                pictureBox15.Enabled = true;
                pictureBox16.Enabled = true;
                pictureBox17.Enabled = true;
                pictureBox18.Enabled = true;
                pictureBox19.Enabled = true;
                pictureBox20.Enabled = true;
                pictureBox21.Enabled = true;
                pictureBox22.Enabled = true;
                pictureBox23.Enabled = true;
                pictureBox24.Enabled = true;

                //Ponemos todos los valores de las frutas a false
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

            }
            
        }
        private bool comprobarParejaSandia()
        {
            if (sandia1 == true && sandia2 == true)
            {
                return true;
            }
            return false;
        }
        private bool comprobarParejaPlatano()
        {
            if (platano1 == true && platano2 == true)
            {
                return true;
            }
            return false;
        }
        private bool comprobarParejaFresa()
        {
            if (fresas1 == true && fresas2 == true)
            {
                return true;
            }
            return false;
        }
        private bool comprobarParejaPeladiño()
        {
            if (peladiño1 == true && peladiño2 == true)
            {
                return true;
            }
            return false;
        }
        private bool comprobarParejaUvas()
        {
            if (uvas1 == true && uvas2 == true)
            {
                return true;
            }
            return false;


        }
        private bool comprobarParejaManzana()
        {
            if (manzana1 == true && manzana2 == true)
            {
                return true;
            }
            return false;


        }
        private bool comprobarParejaCoco()
        {
            if (coco1 == true && coco2 == true)
            {
                return true;
            }
            return false;
        }
        private bool comprobarParejaGranadina()
        {
            if (granadina1 == true && granadina2 == true)
            {
                return true;
            }
            return false;
        }
        private bool comprobarParejaNaranja()
        {
            if (naranja1 == true && naranja2 == true)
            {
                return true;
            }
            return false;
        }
        private bool comprobarParejaPera()
        {
            if (pera1 == true && pera2 == true)
            {
                return true;
            }
            return false;
        }
        private bool comprobarParejaCiruela()
        {
            if (ciruela1 == true && ciruela2 == true)
            {
                return true;
            }
            return false;
        }
        private bool comprobarParejaMelocoton()
        {
            if (melocoton1 == true && melocoton2 == true)
            {
                return true;
            }
            return false;
        }

        private bool ganador()
        {
            if (comprobarParejaCiruela() && comprobarParejaCoco() && comprobarParejaFresa() && comprobarParejaGranadina() && comprobarParejaMelocoton() && comprobarParejaManzana()
              && comprobarParejaPeladiño() && comprobarParejaPera() && comprobarParejaPlatano() && comprobarParejaUvas() && comprobarParejaNaranja() && comprobarParejaSandia())
            {
                MessageBox.Show(mensajeGanador);
                LblTemporizador.Text = "";
                Temporizador.Enabled = false;
                //De la misma forma que en el metodo reiniciar() aqui tambien inicializamos todas nuestras variables
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
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;
                pictureBox10.Enabled = true;
                pictureBox11.Enabled = true;
                pictureBox12.Enabled = true;
                pictureBox13.Enabled = true;
                pictureBox14.Enabled = true;
                pictureBox15.Enabled = true;
                pictureBox16.Enabled = true;
                pictureBox17.Enabled = true;
                pictureBox18.Enabled = true;
                pictureBox19.Enabled = true;
                pictureBox20.Enabled = true;
                pictureBox21.Enabled = true;
                pictureBox22.Enabled = true;
                pictureBox23.Enabled = true;
                pictureBox24.Enabled = true;
                pictureBox1.Image = Resources.Prueba2;
                pictureBox2.Image = Resources.Prueba2;
                pictureBox3.Image = Resources.Prueba2;
                pictureBox4.Image = Resources.Prueba2;
                pictureBox5.Image = Resources.Prueba2;
                pictureBox6.Image = Resources.Prueba2;
                pictureBox7.Image = Resources.Prueba2;
                pictureBox8.Image = Resources.Prueba2;
                pictureBox9.Image = Resources.Prueba2;
                pictureBox10.Image = Resources.Prueba2;
                pictureBox11.Image = Resources.Prueba2;
                pictureBox12.Image = Resources.Prueba2;
                pictureBox13.Image = Resources.Prueba2;
                pictureBox14.Image = Resources.Prueba2;
                pictureBox15.Image = Resources.Prueba2;
                pictureBox16.Image = Resources.Prueba2;
                pictureBox17.Image = Resources.Prueba2;
                pictureBox18.Image = Resources.Prueba2;
                pictureBox19.Image = Resources.Prueba2;
                pictureBox20.Image = Resources.Prueba2;
                pictureBox21.Image = Resources.Prueba2;
                pictureBox22.Image = Resources.Prueba2;
                pictureBox23.Image = Resources.Prueba2;
                pictureBox24.Image = Resources.Prueba2;
                return true;

            }
            return false;
        }

        private bool comprobarTiempo()
        {
            if (contadorTiempoImagen == 0)
            {
                return true;
            }
            return false;


        }
        private void TemporizadorImagen_Tick(object sender, EventArgs e)
        {

            contadorTiempoImagen--;
            //Si al hacer click en una fruta resulta el usuario no consigue hacer una pareja llamaremos a la funcion comprobar tiempo y cuando el temporizador
            //de la imagen sea 0 se mostrara de nuevo la interrogacion y reiniciamos a false las imagenes 
            if (!comprobarParejaCiruela())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox1.Image = Resources.Prueba2;
                    pictureBox4.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    ciruela1 = false;
                    ciruela2 = false;
                }
            }
            if (!comprobarParejaPlatano())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox5.Image = Resources.Prueba2;
                    pictureBox10.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    platano1 = false;
                    platano2 = false;
                }
            }if (!comprobarParejaFresa())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox20.Image = Resources.Prueba2;
                    pictureBox19.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    fresas1 = false;
                    fresas2 = false;
                }
            }if (!comprobarParejaManzana())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox11.Image = Resources.Prueba2;
                    pictureBox6.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    manzana1 = false;
                    manzana2 = false;
                }
            }if (!comprobarParejaMelocoton())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox13.Image = Resources.Prueba2;
                    pictureBox15.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    melocoton1 = false;
                    melocoton2 = false;
                }
            }if (!comprobarParejaUvas())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox17.Image = Resources.Prueba2;
                    pictureBox24.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    uvas1 = false;
                    uvas2 = false;
                }
            }if (!comprobarParejaPeladiño())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox18.Image = Resources.Prueba2;
                    pictureBox9.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    peladiño1 = false;
                    peladiño2 = false;
                }
            }if (!comprobarParejaPera())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox3.Image = Resources.Prueba2;
                    pictureBox12.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    pera1 = false;
                    pera2 = false;
                }
            }if (!comprobarParejaGranadina())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox16.Image = Resources.Prueba2;
                    pictureBox22.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    granadina1 = false;
                    granadina2 = false;
                }
            }if (!comprobarParejaSandia())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox2.Image = Resources.Prueba2;
                    pictureBox7.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    sandia1 = false;
                    sandia2 = false;
                }
            }if (!comprobarParejaCoco())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox8.Image = Resources.Prueba2;
                    pictureBox21.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    coco1 = false;
                    coco2 = false;
                }
            }if (!comprobarParejaNaranja())
            {
                if (comprobarTiempo())
                {
                    //Indicamos que se oculten las imagenes
                    pictureBox23.Image = Resources.Prueba2;
                    pictureBox14.Image = Resources.Prueba2;
                    //Inicializamos a false las imagenes
                    naranja1 = false;
                    naranja2 = false;
                }
            }
            
        }
    }
}