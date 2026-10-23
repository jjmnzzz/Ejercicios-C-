using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Ecuacion
    {
        private double a;
        private double b;
        private double c;

        public Ecuacion(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string Soluciones()
        {
            
            string resultado;
            if (a == 0 && b == 0 && c == 0)
            {
                resultado = "El resultado es 0";
            }
            else if (a == 0 && b == 0)
            {
                resultado = "No se puede realizar el calculo";
            }
            else if (a == 0 && c == 0)
            {
                resultado = "El resultado es 0";
            }
            else if (b == 0 && c == 0)
            {
                resultado = "El resultado es 0";
            }
            else if (a == 0)
            {
                double resultadoA0 = -(c / b);
                resultado = $"El resultado es {resultadoA0}";
            }
            else if (b == 0)
            {
                if (-(c / a) >= 0)
                {
                    double resultadoB0 = Math.Sqrt(-(c / a));
                    resultado = $"El resultado es {resultadoB0}";
                }
                else
                {
                    resultado = "La operacion no se puede completar";
                }
                
            }
            else if (c == 0)
            {
                    double resultadoC01 = 0;
                    double resultadoC02 = -(b / a);
                    resultado = $"Los resultados son {resultadoC01} y {resultadoC02}";
            }
            else
            {
                double operacion = (Math.Pow(b, 2) - (4 * a * c));
                if (operacion < 0)
                {
                    resultado = "La operacion no se puede realizar";
                }
                else
                {
                    double resultado1 = ((-b) + (Math.Sqrt(operacion))) / (2 * a);
                    double resultado2 = ((-b) - (Math.Sqrt(operacion))) / (2 * a);
                    resultado = $"Los resultados son {resultado1} y {resultado2}";
                }
            }
            return resultado;
        }
    }
}
