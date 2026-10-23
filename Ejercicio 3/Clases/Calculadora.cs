using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Calculadora
    {

        private double numero1;
        private double numero2;
        
        public double Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                numero1 = value;
            }
        }

        public double Numero2
        {
            get
            {
                return numero2;
            }
            set
            {
                numero2 = value;
            }
        }

        public double Sumar()
        {
            return Numero1 + Numero2;
        }
        public double Restar()
        {
            return Numero1 - Numero2;
        }
        public double Multiplicar()
        {
            return Numero1 * Numero2;
        }
        public double DividirReal()
        {
            return Numero1 / Numero2;
        }

        public int DividirEntero()
        {

            return (int)(Numero1 / Numero2);
        }

        public double Resto()
        {
            return Numero1 % Numero2;
        }
        public double Potencia()
        {
            return Math.Pow(Numero1, Numero2);
        }
        public bool Num1MayorNum2()
        {
            if (Numero1 > Numero2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EsNum1Positivo()
        {
            if (Numero1 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AlgunoPositivo()
        {
            if (Numero1 > 0 ||  Numero2 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NegativosAmbos()
        {
            if (Numero1 < 0 && Numero2 < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Multiplos()
        {
            if (Numero1 % Numero2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
