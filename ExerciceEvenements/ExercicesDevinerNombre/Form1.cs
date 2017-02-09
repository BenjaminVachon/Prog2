using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicesDevinerNombre
{
    public partial class Form1 : Form
    {
        public Random rng = new Random();
        int nombreRandom;
        int nombreEntre;
        public Form1()
        {
            InitializeComponent();
            nombreRandom = rng.Next(1, 1001);
        }

        private void buttonAccepter_Click(object sender, EventArgs e)
        {
            nombreEntre = int.Parse(textBoxEssaie.Text);
            if (nombreEntre > nombreRandom + 100 || nombreEntre < nombreRandom - 100)
            {
                this.BackColor = Color.Blue;
            }
            else if (nombreEntre < nombreRandom + 100 || nombreEntre > nombreRandom - 100)
            {
                this.BackColor = Color.Red;
            }
            if (nombreEntre > nombreRandom)
            {
            labelResultat.Text = "Trop grand";               
            }
            else if (nombreEntre < nombreRandom)
            {
                labelResultat.Text = "Trop petit";
            }
            else
            {
                labelResultat.Text = "Bravo vous avez trouver mon nombre";
                textBoxEssaie.Enabled = false;
                this.BackColor = Color.Green;
                
            }
        }

        private void buttonRetry_Click(object sender, EventArgs e)
        {
            textBoxEssaie.Enabled = true;
            nombreRandom = rng.Next(1, 1001);
            this.BackColor = Form1.DefaultBackColor;
        }
    }
}
