using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMotCache
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            textBoxAfficher.Text = textBoxCache.Text;
        }

        private void checkBoxItalique_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAfficher.Font = new Font(textBoxAfficher.Font, textBoxAfficher.Font.Style^FontStyle.Italic);
        }

        private void checkBoxGras_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAfficher.Font = new Font(textBoxAfficher.Font, textBoxAfficher.Font.Style ^ FontStyle.Bold);
        }
    }
}
