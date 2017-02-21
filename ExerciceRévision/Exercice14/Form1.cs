using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice14
{  
    public partial class Form1 : Form
    {
        Random rng = new Random();
        bool piece;
        int nombreLancer = 0;
        double pileVictoire = 0;
        double faceVictoire = 0;
        int face = 0;
        int pile = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreLancer++;    
            if(rng.Next(0, 2) == 0)
            {
                piece = true;
            }
            else if(rng.Next(0,2) == 1)
            {
                piece = false;
            }
            else
            {
                labelnblancer.Text = "wtf";
            }

            if(piece == true)
            {
                face++;
                pictureBoxPiece.Image = imageList1.Images[1];
            }
            else
            {
                pile++;
                pictureBoxPiece.Image = imageList1.Images[0];
            }
            faceVictoire = (face * 100) / nombreLancer;
            pileVictoire = (pile * 100) / nombreLancer;
            labelnblancer.Text = Convert.ToString(nombreLancer);
            labelpile.Text = Convert.ToString(pileVictoire) + "%";
            labelface.Text = Convert.ToString(faceVictoire) + "%";

            
        }
    }
}
