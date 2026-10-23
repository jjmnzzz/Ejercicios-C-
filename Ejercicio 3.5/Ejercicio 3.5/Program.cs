using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserte una cadena1: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string cad1 = Console.ReadLine();
            Console.ResetColor();
            Console.Write("Inserte una cadena2: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string cad2 = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("");

            Tupla comprobador = new Tupla(cad1, cad2);

            bool mismoTamano = comprobador.mismaLongitud();
            bool sonIguales = comprobador.sonIguales();
            bool sonIgualesEquals = comprobador.sonIgualesEquals();
            bool sonIgualesPeroEscritasDistintas = comprobador.sonIualesPeroEscritasDistintas();

            Console.WriteLine($"¿El tamaño de cadena1 y cadena2 es el mismo?: {mismoTamano}");
            Console.WriteLine($"¿Cadena1 y cadena2 son iguales?: {sonIguales}");
            Console.WriteLine($"¿Cadena1 y cadena2 son iguales? (con Equals): {sonIgualesEquals}");
            Console.WriteLine($"¿Cadena1 y cadena2 son iguales pero escritas diferente?: {sonIgualesPeroEscritasDistintas}");
            Console.WriteLine("");

            Console.Write("Inserte una nueva cadena para insertar en cadena1: ");
            string textoNuevo = Console.ReadLine();
            Console.Write("Posición en la que desea insertarlo: ");
            int posicion;
            int.TryParse(Console.ReadLine(), out posicion);

            cad1 = comprobador.anadirCadena(posicion, textoNuevo);
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Ahora cadena1 es: {cad1}");
            Console.ResetColor();

            Console.WriteLine("Las siguientes comparaciones se realizas tras pasar a mayúsculas");
            Console.Write("Instroduzca nuevamente cadena2: ");
            cad2 = Console.ReadLine();

            bool cadena1ContieneCadena2 = comprobador.cadena1ContieneACadena2(cad2);
            int primeraPosicionDeCadena2Encadena1 = comprobador.primeraPosicionDeCadena2Encadena1(cad2);
            int segundaPosicionDeCadena2Encadena1 = comprobador.segundaPosicionDeCadena2Encadena1(cad2);
           
            Console.WriteLine($"¿La nueva cadena1 contiene a cadena2?: {cadena1ContieneCadena2}");
            Console.WriteLine($"Primera posicion de cadena1 en cadena2: {primeraPosicionDeCadena2Encadena1}");
            Console.WriteLine($"Primera posicion de cadena1 en cadena2: {segundaPosicionDeCadena2Encadena1}");
            Console.WriteLine("");

            Console.WriteLine("Ahora vamos a extraer un trozo de cadena1");
            Console.Write("Posicion sobre la cual empiezas a cortar: ");
            int.TryParse(Console.ReadLine(), out posicion);
            Console.Write("Cantidad que deseas cortar: ");
            int cantidad;
            int.TryParse(Console.ReadLine(), out cantidad);

            string fraseResultante = comprobador.recortar(posicion, cantidad);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"La frase resultante es: {fraseResultante}");
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
