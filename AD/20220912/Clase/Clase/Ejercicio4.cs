using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Clase
{
    public partial class Ejercicio4 : Form

    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Ejercicio4()
        {
            InitializeComponent();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Claro de Luna");
                listBox1.Items.Add("Sinfonia Nº 5");
                listBox1.Items.Add("Serenata");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Good vibrations");
                listBox1.Items.Add("Yesterday");
                listBox1.Items.Add("Bohemiam rhapsody");
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Wake me up");
                listBox1.Items.Add("Let me love you");
                listBox1.Items.Add("Faded");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "Claro de Luna")
            {

                wplayer.URL = "C:\\Users\\daniel\\Pictures\\Saved Pictures\\Claro de Luna.mp3";
                wplayer.controls.play();

            }
            else if (listBox1.Text == "Sinfonia Nº 5")
            {

                wplayer.URL = "C:\\Users\\daniel\\Pictures\\Saved Pictures\\Sinfonia";
                wplayer.controls.play();
            }

            else if (listBox1.Text == "Serenata")
            {
                wplayer.URL = "C:\\Users\\daniel\\Pictures\\Saved Pictures\\Serenata.mp3";
                wplayer.controls.play();
            }

            if (listBox1.Text == "Good Vibrations")
            {
                wplayer.URL = "C:\\Users\\daniel\\Pictures\\Saved Pictures\\Good vibrations.mp3";
                wplayer.controls.play();

            }
            else if (listBox1.Text == "Yesterday")
            {
                wplayer.URL = "C:\\Users\\daniel\\Pictures\\Saved Pictures\\Yesterday.mp3";
                wplayer.controls.play();

            }
            else if (listBox1.Text == "Bohemian rhapsody")
            {
                wplayer.URL = "C:\\Users\\daniel\\Pictures\\Saved Pictures\\Bohemian rhapsody.mp3";
                wplayer.controls.play();
            }
            if (listBox1.Text == "Wake me up")
            {
                wplayer.URL = "C:\\Users\\daniel\\Pictures\\Saved Pictures\\Wake me up.mp3";
                wplayer.controls.play();

            }
            else if (listBox1.Text == "Let me love you")
            {
                wplayer.URL = "C:\\Users\\daniel\\Pictures\\Saved Pictures\\Let me love you.mp3";
                wplayer.controls.play();

            }
            else if (listBox1.Text == "Faded")
            {
                wplayer.URL = "C:\\Users\\daniel\\Pictures\\Saved Pictures\\Faded.mp3";
                wplayer.controls.play();







            }
        }
    }
}
