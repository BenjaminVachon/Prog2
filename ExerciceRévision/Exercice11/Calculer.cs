using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice11
{
    class Calculer
    {
        public double CirconferenceCercle(double rayon)
        {
            return rayon * Math.PI;
        }

        public double AireCercle(double rayon)
        {
            return Math.Pow(rayon, 2) * Math.PI;
        }

        public double AireSurfaceSphere(double  rayon)
        {
            return Math.Pow(rayon, 2) * Math.PI * 4;
        }

        public double VolumeSphere(double rayon)
        {
            return (4 / 3) * Math.Pow(rayon, 3) * Math.PI;
        }

        public double VolumeCone(double rayon, double hauteur)
        {
            return Math.PI * Math.Pow(rayon, 2) * hauteur / 3;
        }

        public double VolumeCylindre(double rayon, double hauteur)
        {
            return Math.PI * Math.Pow(rayon, 2) * hauteur;
        }
    }
}
