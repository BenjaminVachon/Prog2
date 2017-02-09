using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempleImage
{
    public partial class FormImages : Form
    {
        private int indice = 0;

        public FormImages()
        {
            InitializeComponent();
        }

        private void pictureBoxImages_Click(object sender, EventArgs e)
        {
            indice = (indice + 1) % imageList1.Images.Count;
            pictureBoxImages.Image = imageList1.Images[indice];
        }
    }
}
