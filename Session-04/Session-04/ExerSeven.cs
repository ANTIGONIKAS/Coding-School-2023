using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExerSeven
    {

        // x°C + 273.15 = 293.15K
        // (x°C × 9/5) + 32 = 68°F

        public int ConvertCelsiusToKelvin()
        {
            int x = 25; // x = Celsius Degree
            return x+273;
        }
        public double ConvertCelsiusToFahrenheit()
        {
            int x = 25; // x = Celsius Degree
            return (x * (9.0/5.0)) + 32;
        }

    }
}
