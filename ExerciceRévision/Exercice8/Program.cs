using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] client = new double[3];

            for (int i = 0; i < client.Length; i++)
            {
                i++;
                Console.WriteLine("entrer votre nombre d'heures client " + i);
                Stationnement test = new Stationnement(double.Parse(Console.ReadLine()));
                client[i] = test.CalculerCout();
                i--;
            }
            Console.Clear();
            for (int i = 0; i < client.Length; i++)
            {
                i++;
                Console.WriteLine("cout client " + i + " est de " + client[i]);
                i--;
            }

            Console.ReadKey();
        }
    }
}
