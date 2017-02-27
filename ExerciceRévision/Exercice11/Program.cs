using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculer test = new Calculer();

            Console.WriteLine(test.CirconferenceCercle(5));
            Console.WriteLine(test.AireCercle(5));
            Console.WriteLine(test.AireSurfaceSphere(5));
            Console.WriteLine(test.VolumeSphere(5));
            Console.WriteLine(test.VolumeCylindre(5, 4));
            Console.WriteLine(test.VolumeCone(5, 4));

            Console.ReadKey();
        }
    }
}
