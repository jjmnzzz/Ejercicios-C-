using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La fecha de hoy es: " + DateTime.Now.ToLongDateString());
            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca su fecha de nacimiento: ");
            DateTime fechaNacimiento;

            if (!DateTime.TryParse(Console.ReadLine(), out fechaNacimiento) || (fechaNacimiento > DateTime.Now))
            {
                Console.WriteLine("Formato de fecha erróneo");

                Console.WriteLine("Pulse cualquier tecla para finalizar... ");
                Console.ReadKey();
                return;
            }

            Persona persona = new Persona(nombre, fechaNacimiento);

            Console.WriteLine($"Usted tiene: {persona.Anyos()} años.");

            if (DateTime.Now.ToString("dd/MM") == fechaNacimiento.ToString("dd/MM"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¡Felicidades, hoy es su cumpleaños!");
                Console.ResetColor();
            }

            Console.WriteLine("Pulse cualquier tecla para finalizar... ");
            Console.ReadKey();
        }
    }
}