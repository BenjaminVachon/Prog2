using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRévision2
{
    class Distance
    {
        public double pointA { get; set; }
        public double pointB { get; set; }
        /// <summary>
        /// Instancie une distance
        /// </summary>
        public Distance()
        {
        }

        public double CalculeDistance(double pointA, double pointB)
        {
            double valeur = 0;
            if (pointA > pointB)
            {
               valeur = pointA - pointB;
            }
            else if (pointB > pointA)
            {
               valeur = pointB - pointA;
            }
            else
            {
                valeur = 0;
            }
            return valeur;
        }
    }
}
