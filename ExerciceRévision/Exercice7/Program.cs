using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quel est la note que vous voulez transférer en lettre ? ");
            NoteEnLettre test = new NoteEnLettre(int.Parse(Console.ReadLine()));

            Console.WriteLine(test.Lettre());

            Console.ReadKey();
        }
    }
}
