using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice9
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrondir test = new Arrondir(550);
            Console.Write("Arrondie au dixième: ");
            Console.WriteLine(test.ArrondirDixieme());
            Console.Write("Arrondie au centième: ");
            Console.WriteLine(test.ArrondirCentaine());
            Console.Write("Arrondie au millième: ");
            Console.WriteLine(test.ArrondirMille());

            Console.ReadKey();
        }
    }
}
