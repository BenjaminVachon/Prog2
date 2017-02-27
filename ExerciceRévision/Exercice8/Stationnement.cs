using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8
{
    class Stationnement
    {
        public double heure;
    
        public Stationnement(double heure)
        {
            this.heure = heure;
        }

        public double CalculerCout()
        {
            if (heure <= 3)
            {
                return 2;
            }
            else
            {
                double prix = 2 + ((heure - 3) * 0.5);
                if(prix >= 10)
                {
                    return 10;
                }
                else
                {
                    return prix;
                }
            }
        }
    }
}
