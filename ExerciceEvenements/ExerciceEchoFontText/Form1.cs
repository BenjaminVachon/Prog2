using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceEchoFontText
{
    public partial class Form1 : Form
    {
        public int size = 0;
        public Form1()
        {
            InitializeComponent();
            
      
        }

        private void numericUpDownTaille_ValueChanged(object sender, EventArgs e)
        {
            size = Convert.ToInt16(numericUpDownTaille.Value);
            richTextBoxZone.Font = new Font(richTextBoxZone.Font.FontFamily, size);
        }

        private void richTextBoxZone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
