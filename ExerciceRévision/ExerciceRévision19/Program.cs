using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRévision19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Jeux test = new Jeux();
            int reponse;

            do
            {
                test.GetNombreAlea();
                Console.WriteLine("Combien font " + test.nb1 + " * " + test.nb2);
                reponse = int.Parse(Console.ReadLine());
                if (test.nb1 * test.nb2 == reponse)
                {
                    Console.WriteLine(test.message[rng.Next(0, 5)]);
                }
                else
                {
                    Console.WriteLine(test.message[rng.Next(5, 9)]);
                }
            } while (reponse != -1);
            Console.ReadKey();
        }
    }
}
