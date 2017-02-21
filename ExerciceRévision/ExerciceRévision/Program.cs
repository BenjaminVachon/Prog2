using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRévision
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomInclus rng = new RandomInclus();
            int alea = rng.EntierRandom(0, 100);
            Console.Write(alea);
            Console.ReadKey();
        }
    }
}
