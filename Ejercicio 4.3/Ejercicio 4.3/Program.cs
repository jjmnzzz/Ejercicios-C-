using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Clases;

namespace Ejercicio_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para la ecuación de segundo grado inserte valores a, b y c: ");
            Console.Write("Valor a: ");
            double a;
            if(!double.TryParse(Console.ReadLine(),out a)){
                Console.WriteLine("El formato no es correcto. ");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }
            Console.Write("Valor b: ");
            double b;
            if (!double.TryParse(Console.ReadLine(), out b)){
                Console.WriteLine("El formato no es correcto. ");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }
            Console.Write("Valor c: ");
            double c;
            if (!double.TryParse(Console.ReadLine(), out c)){
                Console.WriteLine("El formato no es correcto. ");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            Ecuacion soluciones = new Ecuacion(a,b,c);
            string resultado = soluciones.Soluciones();
            Console.WriteLine(resultado);
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
