using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceEvenements
{
    public partial class FormDessin : Form
    {
        private Graphics surface;
        private bool dessiner;
        int size = 4;
        public Color couleur = Color.Black;
        public FormDessin()
        {
            InitializeComponent();
            surface = CreateGraphics();
            dessiner = false;
            
            
        }

        

        private void FormDessin_MouseDown(object sender, MouseEventArgs e)
        {
            dessiner = true;
        }

        private void FormDessin_MouseUp(object sender, MouseEventArgs e)
        {
            dessiner = false;
        }

        private void FormDessin_MouseMove(object sender, MouseEventArgs e)
        {
            SolidBrush crayon = new SolidBrush(couleur);
            if (dessiner)
            { surface.FillEllipse(crayon, e.X, e.Y, size, size); }
        }
        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            couleur = Color.Red;
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            couleur = Color.Green;
        }

        private void radioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            couleur = Color.Black;
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            size = 2;
        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            size = 4;
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            size = 8;
        }
    }
}
