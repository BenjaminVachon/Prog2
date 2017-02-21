using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceRévision
{
    /// <summary>
    /// Permet d'avoir un random avec un maximum inclusif
    /// </summary>
    class RandomInclus
    {
        private Random rng = new Random();
        public int min { get; set; }
        public int max { get; set; }
        /// <summary>
        /// Crée le "Random"
        /// </summary>
        public RandomInclus()
        {
        }
        /// <summary>
        /// Retourne un entier aléatoire
        /// </summary>
        /// <param name="min">Nombre minimum, est inclus</param>
        /// <param name="max">Nombre maximum, est inclus</param>
        /// <returns></returns>
        public int EntierRandom(int min, int max)
        {
            int alea = rng.Next(min, max + 1);
            return alea;
        }
    }
}
