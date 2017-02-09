using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempleSouris
{
    public partial class FormDessin : Form
    {
        private Graphics surface;
        private bool dessiner;

        public FormDessin()
        {
            InitializeComponent();
            surface = CreateGraphics();
            dessiner = false;
        }

        private void FormDessin_Load(object sender, EventArgs e)
        {
            
        }

        private void FormDessin_MouseMove(object sender, MouseEventArgs e)
        {
            SolidBrush crayon = new SolidBrush(Color.Black);
            if (dessiner)
            { surface.FillEllipse(crayon, e.X, e.Y, 4, 4); }
               
        }
        
        

        

        private void FormDessin_MouseUp(object sender, MouseEventArgs e)
        {
            dessiner = false;
        }

        private void FormDessin_MouseDown(object sender, MouseEventArgs e)
        {
            dessiner = true;
        }
    }
}
