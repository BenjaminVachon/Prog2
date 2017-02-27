using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle test = new Triangle(3, 4);

            double Hypothenuse = test.CalculerHypothenuse();

            Console.WriteLine(Hypothenuse);

            Console.ReadKey();
        }
    }
}
