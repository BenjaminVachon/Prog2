using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceClavier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// On gère l'intégrité des touche ajouter au clavier du forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Le code de la touche appuyer</param>
        public void EtatClavier(object sender, System.Windows.Forms.KeyEventArgs e)
        { 
            //Q
            if (e.KeyCode == Keys.Q)
            {
                buttonQ.BackColor = Color.Red;
            }
            else
            {
                buttonQ.BackColor = Color.Black;
            }
            //W
            if (e.KeyCode == Keys.W)
            {
                buttonW.BackColor = Color.Red;
            }
            else
            {
                buttonW.BackColor = Color.Black;
            }
            //E
            if (e.KeyCode == Keys.E)
            {
                buttonE.BackColor = Color.Red;
            }
            else
            {
                buttonE.BackColor = Color.Black;
            }
            //R
            if (e.KeyCode == Keys.R)
            {
                buttonR.BackColor = Color.Red;
            }
            else
            {
                buttonR.BackColor = Color.Black;
            }
            //T
            if (e.KeyCode == Keys.T)
            {
                buttonT.BackColor = Color.Red;
            }
            else
            {
                buttonT.BackColor = Color.Black;
            }
            //Y
            if (e.KeyCode == Keys.Y)
            {
                buttonY.BackColor = Color.Red;
            }
            else
            {
                buttonY.BackColor = Color.Black;
            }
            //U
            if (e.KeyCode == Keys.U)
            {
                buttonU.BackColor = Color.Red;
            }
            else
            {
                buttonU.BackColor = Color.Black;
            }
            //I
            if (e.KeyCode == Keys.I)
            {
                buttonI.BackColor = Color.Red;
            }
            else
            {
                buttonI.BackColor = Color.Black;
            }
            //O
            if (e.KeyCode == Keys.O)
            {
                buttonO.BackColor = Color.Red;
            }
            else
            {
                buttonO.BackColor = Color.Black;
            }
            //P
            if (e.KeyCode == Keys.P)
            {
                buttonP.BackColor = Color.Red;
            }
            else
            {
                buttonP.BackColor = Color.Black;
            }
            //A
            if (e.KeyCode == Keys.A)
            {
                buttonA.BackColor = Color.Red;
            }
            else
            {
                buttonA.BackColor = Color.Black;
            }
            //S
            if (e.KeyCode == Keys.S)
            {
                buttonS.BackColor = Color.Red;
            }
            else
            {
                buttonS.BackColor = Color.Black;
            }
            //D
            if (e.KeyCode == Keys.D)
            {
                buttonD.BackColor = Color.Red;
            }
            else
            {
                buttonD.BackColor = Color.Black;
            }
            //F
            if (e.KeyCode == Keys.F)
            {
                buttonF.BackColor = Color.Red;
            }
            else
            {
                buttonF.BackColor = Color.Black;
            }
            //G
            if (e.KeyCode == Keys.G)
            {
                buttonG.BackColor = Color.Red;
            }
            else
            {
                buttonG.BackColor = Color.Black;
            }
            //H
            if (e.KeyCode == Keys.H)
            {
                buttonH.BackColor = Color.Red;
            }
            else
            {
                buttonH.BackColor = Color.Black;
            }
            //J
            if (e.KeyCode == Keys.J)
            {
                buttonJ.BackColor = Color.Red;
            }
            else
            {
                buttonJ.BackColor = Color.Black;
            }
            //K
            if (e.KeyCode == Keys.K)
            {
                buttonK.BackColor = Color.Red;
            }
            else
            {
                buttonK.BackColor = Color.Black;
            }
            //L
            if (e.KeyCode == Keys.L)
            {
                buttonL.BackColor = Color.Red;
            }
            else
            {
                buttonL.BackColor = Color.Black;
            }
            //Z
            if (e.KeyCode == Keys.Z)
            {
                buttonZ.BackColor = Color.Red;
            }
            else
            {
                buttonZ.BackColor = Color.Black;
            }
            //X
            if (e.KeyCode == Keys.X)
            {
                buttonX.BackColor = Color.Red;
            }
            else
            {
                buttonX.BackColor = Color.Black;
            }
            //C
            if (e.KeyCode == Keys.C)
            {
                buttonC.BackColor = Color.Red;
            }
            else
            {
                buttonC.BackColor = Color.Black;
            }
            //V
            if (e.KeyCode == Keys.V)
            {
                buttonV.BackColor = Color.Red;
            }
            else
            {
                buttonV.BackColor = Color.Black;
            }
            //B
            if (e.KeyCode == Keys.B)
            {
                buttonB.BackColor = Color.Red;
            }
            else
            {
                buttonB.BackColor = Color.Black;
            }
            //N
            if (e.KeyCode == Keys.N)
            {
                buttonN.BackColor = Color.Red;
            }
            else
            {
                buttonN.BackColor = Color.Black;
            }
            //M
            if (e.KeyCode == Keys.M)
            {
                buttonM.BackColor = Color.Red;
            }
            else
            {
                buttonM.BackColor = Color.Black;
            }
            //1
            if (e.KeyCode == Keys.D1)
            {
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Black;
            }
            //2
            if (e.KeyCode == Keys.D2)
            { 
                button2.BackColor = Color.Red;
            }
            else
            {
                button2.BackColor = Color.Black;
            }
            //3
            if (e.KeyCode == Keys.D3)
            {
                button3.BackColor = Color.Red;
            }
            else
            {
                button3.BackColor = Color.Black;
            }
            //4
            if (e.KeyCode == Keys.D4)
            {
                button4.BackColor = Color.Red;
            }
            else
            {
                button4.BackColor = Color.Black;
            }
            //5
            if (e.KeyCode == Keys.D5)
            {
                button5.BackColor = Color.Red;
            }
            else
            {
                button5.BackColor = Color.Black;
            }
            //6
            if (e.KeyCode == Keys.D6)
            {
                button6.BackColor = Color.Red;
            }
            else
            {
                button6.BackColor = Color.Black;
            }
            //7
            if (e.KeyCode == Keys.D7)
            {
                button7.BackColor = Color.Red;
            }
            else
            {
                button7.BackColor = Color.Black;
            }
            //8
            if (e.KeyCode == Keys.D8)
            {
                button8.BackColor = Color.Red;
            }
            else
            {
                button8.BackColor = Color.Black;
            }
            //9
            if (e.KeyCode == Keys.D9)
            {
                button9.BackColor = Color.Red;
            }
            else
            {
                button9.BackColor = Color.Black;
            }
            //0
            if (e.KeyCode == Keys.D0)
            {
                button0.BackColor = Color.Red;
            }
            else
            {
                button0.BackColor = Color.Black;
            }
            //espace
            if (e.KeyCode == Keys.Space)
            {
                buttonSpace.BackColor = Color.Red;
            }
            else
            {
                buttonSpace.BackColor = Color.Black;
            }
            //backspace
            if (e.KeyCode == Keys.Back)
            {
                buttonBackspace.BackColor = Color.Red;
            }
            else
            {
                buttonBackspace.BackColor = Color.Black;
            }
            //enter
            //enter fonctionne pas je j'ai pas de num pad enter et return ne fait pas illuminé le button enter
            if (e.KeyCode == Keys.Return)
            {
                buttonEnter.BackColor = Color.Red;
            }
            else
            {
                buttonEnter.BackColor = Color.Black;
            }

        }
    }
}