using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conversiones;

namespace Ejercicio_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Objetos:

            Conversionador conversion = new Conversionador();

            // Grados:
            
            double gradosCel;
            double gradosF;
            double gradosK;

            // Conversiones Celsius a:
            
            double celFarenheit;
            double celKelvin;

            // Conversiones Farenheit a:

            double farCelsius;
            double farKelvin;

            // Conversiones Kelvin a:

            double kelCelsius;
            double kelFarenheit;

            // Celsius a Farenheit y Kelvin.
            
            Console.Write("Introduzca temperatura en ºCelsius: ");
            string texto = Console.ReadLine();
            double.TryParse(texto, out gradosCel);

            conversion.Celsius = gradosCel;

            celFarenheit = conversion.CelsiusFarenheit();
            celKelvin = conversion.CelsiusKelvin();

            Console.WriteLine($"Los resultados de la conversión de {conversion.Celsius}º Celsius a Farenheit y Kelvin son: ");
            Console.WriteLine($"Farenheit: {celFarenheit}F");
            Console.WriteLine($"Kelvin: {celKelvin}K");
            Console.WriteLine("");

            //Farenheit a Celsius y Kelvin.
        
            Console.Write("Introduzca temperatura en ºFarenheit: ");
            texto = Console.ReadLine();
            double.TryParse(texto, out gradosF);

            conversion.IntroducirFarenheit(gradosF);

            farCelsius = conversion.CelsiusCelsius();
            farKelvin = conversion.CelsiusKelvin();

            Console.WriteLine($"Los resultados de la conversión de {gradosF}º Farenheit a Celsius y Kelvin son: ");
            Console.WriteLine($"Celsius: {farCelsius}C");
            Console.WriteLine($"Kelvin: {farKelvin}K");
            Console.WriteLine("");

            //Farenheit a Celsius y Kelvin.

            Console.Write("Introduzca temperatura en ºKelvin: ");
            texto = Console.ReadLine();
            double.TryParse(texto, out gradosK);

            conversion.IntroducirKelvin(gradosK);

            kelCelsius = conversion.CelsiusCelsius();
            kelFarenheit = conversion.CelsiusFarenheit();

            Console.WriteLine($"Los resultados de la conversión de {gradosF}º Kelvin a Celsius y Farenheit son: ");
            Console.WriteLine($"Celsius: {kelCelsius}C");
            Console.WriteLine($"Farenheit: {kelFarenheit}F");
            Console.WriteLine("");

            // FInalizar programa.

            Console.Write("Presione para finalizar... ");
            Console.ReadLine();

        }
    }
}
