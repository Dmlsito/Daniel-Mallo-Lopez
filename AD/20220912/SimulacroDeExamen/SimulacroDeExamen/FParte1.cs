using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacroDeExamen
{
    public partial class FParte1 : Form
    {
        public FParte1()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            label1();
        }

       private void label1()
        {
            Label label1 = new Label();
            label1.Name = "label1";
            label1.Text = "Examen Windows Forms1";
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Size = new System.Drawing.Size(800, 100);
            label1.BackColor = Color.Aqua;
            this.Controls.Add(label1);

        }

       
    }
}
