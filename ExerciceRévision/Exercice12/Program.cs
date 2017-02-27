using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice12
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcule test = new Calcule(10, 3);

            Console.WriteLine(test.CalculerPartieEntier());
            Console.WriteLine(test.CalculerReste());

            Console.ReadKey();
        }
    }
}
