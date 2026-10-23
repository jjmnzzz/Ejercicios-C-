using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAdivinar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            int intentos = 0;
            int adivinanza = 0;

            while(adivinanza != numeroSecreto)
            {
                Console.Write("Elija un número del 1 al 100: ");
                if (!int.TryParse(Console.ReadLine(), out adivinanza) || adivinanza <=1 || adivinanza >= 100)
                {
                    Console.WriteLine("Por favor inserte un número del 1 al 100...");
                    Console.WriteLine("");
                    continue;
                }

                intentos++;

                if (adivinanza < numeroSecreto)
                {
                    Console.WriteLine($"El numero secreto es mayor que {adivinanza}.");
                    Console.WriteLine("");
                    continue;
                }
                else if (adivinanza > numeroSecreto)
                {
                    Console.WriteLine($"El numero secreto es menor que {adivinanza}.");
                    Console.WriteLine("");
                    continue;
                }
                else
                {
                    Console.WriteLine($"¡Felicidades! acertó el número en {intentos} intentos.");
                    Console.WriteLine("");
                }

            }

            Console.WriteLine("");
            Console.WriteLine("Pulse cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
