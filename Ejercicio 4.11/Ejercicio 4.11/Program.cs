using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_4._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su peso: ");
            string pesoStr = Console.ReadLine();
            double peso;
            if (string.IsNullOrEmpty(pesoStr) || !double.TryParse(pesoStr, out peso) || peso <= 0)
            {
                Console.WriteLine("El valor introducido no es aceptado.");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            Console.Write("Introduzca su altura: ");
            string alturaStr = Console.ReadLine();
            double altura;
            if (string.IsNullOrEmpty(alturaStr) || !double.TryParse(alturaStr, out altura) || altura < 0.5 || altura > 2.5)
            {
                Console.WriteLine("El valor introducido no es aceptado.");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            Console.Write("Introduzca su edad: ");
            string edadStr = Console.ReadLine();
            int edad;
            if (string.IsNullOrEmpty(edadStr) || !int.TryParse(edadStr, out edad) || edad < 0 || edad > 150)
            {
                Console.WriteLine("El valor introducido no es aceptado.");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            Nutricion nutricion = new Nutricion(peso, altura, edad);

            Console.WriteLine($"La fecha de hoy es {DateTime.Now.ToShortTimeString()}.");
            Console.WriteLine($"Su IMC es: {nutricion.CalcularIMC()}");
            Console.WriteLine($"Por lo tanto se sitúa en la categoría de: {nutricion.EstadoIMC()}");
            Console.WriteLine($"Recomendación: {nutricion.RecomendacionMedica()}");

            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
