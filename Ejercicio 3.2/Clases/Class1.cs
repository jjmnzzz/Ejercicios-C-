using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    
    public class Conversionador
    {
        private double celsius;

        public double Celsius
        {
            get
            {
                return celsius;
            }
            set
            {
                celsius = value;
            }
        }

        public double CelsiusCelsius()
        {
            return Celsius;
        }

        public double CelsiusFarenheit()
        {
            return (Celsius * 1.8) + 32;
        }

        public double CelsiusKelvin()
        {
            return Celsius + 273.15;
        }

        public void IntroducirFarenheit(double Farenheit)
        {
            Celsius = (Farenheit - 32) * 5 / 9;
        }

        public void IntroducirKelvin(double Kelvin)
        {
            Celsius = Kelvin - 273.15;
        }


    }
}
