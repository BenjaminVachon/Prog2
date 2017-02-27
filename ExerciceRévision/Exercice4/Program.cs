using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiple test = new Multiple(3, 8);

            if(test.EstMultiple() == true)
            {
                Console.WriteLine("les nombres " + test.nombre1 + " et " + test.nombre2 + " sont multiples");
            }
            else
            {
                Console.WriteLine("les nombres " + test.nombre1 + " et " + test.nombre2 + " ne sont pas multiples");
            }

            Console.ReadKey()
                ;
        }
    }
}
