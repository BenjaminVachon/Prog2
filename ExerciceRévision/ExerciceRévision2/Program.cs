using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRévision2
{
    class Program
    {
        static void Main(string[] args)
        {
            Distance km = new Distance();

            double lmao = km.CalculeDistance(20, 99);
            Console.WriteLine(lmao);
            Console.ReadKey();
        }
    }
}
