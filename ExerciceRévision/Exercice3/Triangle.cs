using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Triangle
    {
        double A, B;

        public Triangle(double A, double B)
        {
            this.A = A;
            this.B = B;
        }

        public double CalculerHypothenuse()
        {
            return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }


    }
}
