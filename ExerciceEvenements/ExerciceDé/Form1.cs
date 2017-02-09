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
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxnoir_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownnoir.Enabled = true;
        }

        private void checkBoxblanc_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownblanc.Enabled = true;
        }

        private void checkBoxrouge_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownrouge.Enabled = true;
        }
    }
}
