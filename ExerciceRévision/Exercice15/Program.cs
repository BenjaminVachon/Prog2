using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice15
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombre = int.Parse(Console.ReadLine());
            int logArrondi = Convert.ToInt32(Math.Log(nombre, 2));
            
            Console.WriteLine(logArrondi);
            Console.ReadLine();
        }
    }
}
