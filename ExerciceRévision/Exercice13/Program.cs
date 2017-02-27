using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice13
{
    class Program
    {
        static void Main(string[] args)
        {
            Convertir test = new Convertir();

            Console.WriteLine(test.ConvertirCelsius(90));
            Console.WriteLine(test.ConvertirFahrenheit(90));

            Console.ReadKey();
        }
    }
}
