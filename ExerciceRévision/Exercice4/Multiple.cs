using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class Multiple
    {
        public double nombre1;
        public double nombre2;

        public Multiple(double nombre1, double nombre2)
            {
            this.nombre1 = nombre1;
            this.nombre2 = nombre2;
            }

        public bool EstMultiple()
        {
            if(nombre1 % nombre2 == 0 || nombre2 % nombre1 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
