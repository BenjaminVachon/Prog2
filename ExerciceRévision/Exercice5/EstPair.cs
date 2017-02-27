using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class EstPair
    {
        public int nombre1;

        public EstPair(int nombre1)
        {
            this.nombre1 = nombre1;
        }

        public string Pair()
        {
            bool pair;
            if (nombre1 % 2 == 0)
            {
                pair = true;
            }
            else
            {
                pair = false;
            }

            if (pair)
            {
                return "nombre pair";
            }
            else
            {
                return "nombre impair";
            }
        }
    }
}
