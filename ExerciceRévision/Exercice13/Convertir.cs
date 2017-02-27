using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice13
{
    class Convertir
    {
        public Convertir()
        {

        }

        public double ConvertirCelsius(double tempF)
        {
            return (tempF - 32) * 5 / 9;
        }

        public double ConvertirFahrenheit(double tempC)
        {
            return tempC * 1.8 + 32;
        }


    }
}