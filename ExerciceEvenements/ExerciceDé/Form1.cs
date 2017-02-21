using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceDé
{
    public partial class Form1 : Form
    {
        public int noir = 0, blanc = 0, rouge = 0;
        public double prixN = 0, prixB = 0, prixR = 0;
        public double transport = 0;
        public double total = 0;

        public Form1()
        {
            InitializeComponent();
            numericUpDownnoir.Enabled = false;
            numericUpDownblanc.Enabled = false;
            numericUpDownrouge.Enabled = false;
        }

        private void checkBoxnoir_CheckedChanged(object sender, EventArgs e)
        {
            noir++;
            if (noir % 2 == 0)
            {
                numericUpDownnoir.Enabled = false;
            }
            else
            {
                numericUpDownnoir.Enabled = true;
            }
        }     

        private void checkBoxblanc_CheckedChanged(object sender, EventArgs e)
        {
            blanc++;
            if (blanc % 2 == 0)
            {
                numericUpDownblanc.Enabled = false;
            }
            else
            {
                numericUpDownblanc.Enabled = true;
            }
        }

        private void checkBoxrouge_CheckedChanged(object sender, EventArgs e)
        {
            rouge++;
            if (rouge % 2 == 0)
            {
                numericUpDownrouge.Enabled = false;
            }
            else
            {
                numericUpDownrouge.Enabled = true;
            }
        }

        private void buttonaccept_Click(object sender, EventArgs e)
        {
            if(numericUpDownblanc.Value + numericUpDownnoir.Value + numericUpDownrouge.Value >= 20)
            {
                transport = 0;
            }
            else if (numericUpDownblanc.Value + numericUpDownnoir.Value + numericUpDownrouge.Value == 0)
            {
                transport = 0;
            }
            else
            {
                transport = 1.5;
            }
            prixN = Convert.ToDouble(numericUpDownnoir.Value) * 1.5;
            prixB = Convert.ToDouble(numericUpDownblanc.Value) * 1.5;
            prixR = Convert.ToDouble(numericUpDownrouge.Value) * 1.5;
            total = ((prixN + prixB + prixR) * 1.05) + transport;
            textBoxTotal.Text = Convert.ToString(total);
        }

    }
}
