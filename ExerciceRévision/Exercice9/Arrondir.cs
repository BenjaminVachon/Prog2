using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice9
{
    class Arrondir
    {
        public int nombre;

        public Arrondir(int nombre)
        {
            this.nombre = nombre;
        }

        public int ArrondirEntier()
        {
            int nombreArrondi = Convert.ToInt16(nombre);
            return nombreArrondi;
        }

        public int ArrondirDixieme()
        {
            if(nombre % 10 >= 5)
            {
                int add = 10 - (nombre % 10);
                return nombre + add;
            }
            else
            {
                return nombre - (nombre % 10);
            }
        }

        public int ArrondirCentaine()
        {
            if (nombre % 100 >= 50)
            {
                int add = 100 - (nombre % 100);
                return nombre + add;
            }
            else
            {
                return nombre - (nombre % 100);
            }
        }
        public int ArrondirMille()
        {
            if (nombre % 1000 >= 500)
            {
                int add = 1000 - (nombre % 1000);
                return nombre + add;
            }
            else
            {
                return nombre - (nombre % 1000);
            }
        }


    }
}
