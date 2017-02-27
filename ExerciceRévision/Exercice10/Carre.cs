using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice10
{
    class Carre
    {
        public char symbole;

        public Carre(char symbole)
        {
            this.symbole = symbole;
        }

        public void AfficherCarre()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                     Console.Write(symbole);
                }
                Console.WriteLine();
            }

        }
    }
}
