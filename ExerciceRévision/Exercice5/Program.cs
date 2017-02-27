using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            EstPair test = new EstPair(6);

            Console.WriteLine(test.Pair());

            Console.ReadKey();
        }
    }
}
