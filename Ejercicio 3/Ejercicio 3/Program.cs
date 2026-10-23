using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Calculadora operaciones = new Calculadora();

            double num1;
            double num2;

            Console.Write("Digite el primer número: ");
            double.TryParse(Console.ReadLine(), out num1);

            Console.Write("Digite el segundo número: ");
            double.TryParse(Console.ReadLine(), out num2);

            operaciones.Numero1 = num1;
            operaciones.Numero2 = num2;

            Console.WriteLine($"Los resultado de los calculos entre {operaciones.Numero1} y {operaciones.Numero2} son: ");
            Console.WriteLine("Resultado suma: " + operaciones.Sumar());
            Console.WriteLine("Resultado resta: " + operaciones.Restar());
            Console.WriteLine("Resultado multiplicación: " + operaciones.Multiplicar());
            Console.WriteLine("Resultado división real: " + operaciones.DividirReal());
            Console.WriteLine("Resultado división entera: " + operaciones.DividirEntero());
            Console.WriteLine("El resto de la división entera: " + operaciones.Resto());
            Console.WriteLine("Resultado potencia: " + operaciones.Potencia());
            Console.WriteLine("");
            Console.WriteLine("¿El número 1 es mayor que el número 2?: " + operaciones.Num1MayorNum2());
            Console.WriteLine("¿El número 1 es positivo?: " + operaciones.EsNum1Positivo());
            Console.WriteLine("¿Alguno de los dos números es positivo?: " + operaciones.AlgunoPositivo());
            Console.WriteLine("¿Ambos son negativos?: " + operaciones.NegativosAmbos());
            Console.WriteLine("¿El número 1 es multiplo de número 2?: " + operaciones.Multiplos());
            Console.WriteLine("Pulsa cualquier tecla para salir...");

            Console.ReadLine();
        }
    }
}
