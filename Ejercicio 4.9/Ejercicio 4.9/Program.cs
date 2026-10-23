using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_4._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos minutos lleva estacionado?: ");
            int minutos;
            if(!int.TryParse(Console.ReadLine(), out minutos) || minutos <= 0){
                Console.WriteLine("Número no aceptado.");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            Console.Write("¿El coche es eléctrico (S/N)?: ");
            bool esElectrico;
            string respuesta = Console.ReadLine().ToUpper();
            if (respuesta == "SI" || respuesta == "S" || respuesta == "NO" || respuesta == "N" || respuesta == "SÍ")
            {
                if (respuesta == "SI" || respuesta == "S" || respuesta == "SÍ")
                {
                    esElectrico = true;
                }
                else
                {
                    esElectrico = false;
                }
            }
            else
            {
                Console.WriteLine("Respuesta no aceptada.");
                Console.WriteLine("");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            TicketParking parking = new TicketParking(minutos, esElectrico);
            
            Console.WriteLine("");
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Desglose del precio:");
            Console.ResetColor();
            Console.WriteLine($"Minutos: {minutos}");
            Console.WriteLine($"¿Eléctrico?: {esElectrico}");
            Console.WriteLine("__________________");
            Console.WriteLine($"Precio total: {parking.CalcularImporte()}€");

            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
