using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverters
    {

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var celsuis = (fahrenheit - 32) * 5 / 9;
            return celsuis;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            var fahrenheit = (celsius * 9) / 5 + 32;
            return fahrenheit;
        }
    }
}
