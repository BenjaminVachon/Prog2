using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice12
{
    class Calcule
    {
        public int nombre1;
        public int nombre2;

        public Calcule(int nombre1, int nombre2)
        {
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
        }

        public int CalculerPartieEntier()
        {
            return nombre1 / nombre2;
        }

        public int CalculerReste()
        {
            return nombre1 % nombre2;
        }
    }
}
