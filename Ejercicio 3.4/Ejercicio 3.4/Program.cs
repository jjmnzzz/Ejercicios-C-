using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            string subcadena;
            string otroTexto;
            string palabraRemplazar;
            string textoRemplazar;
            string textoRemplazado;

            string textoMayusculas;
            string textoMinusculas;
            int longitud;
            bool contieneSubcadena;
            bool comienzaPor;
            bool mismaLongitud;

            Console.Write("Introduzca palabra: ");
            texto = Console.ReadLine();
            Console.WriteLine("");

            ProcesadorTexto procesador = new ProcesadorTexto(texto);

            textoMayusculas = procesador.obtenerMayusculas();
            textoMinusculas = procesador.obtenerMinusculas();
            longitud = procesador.Longitud();

            Console.WriteLine($"Texto introducido: {texto}");
            Console.WriteLine($"El texto en mayúsculas es: {textoMayusculas}");
            Console.WriteLine($"El texto en minúsculas es: {textoMinusculas}");
            Console.WriteLine($"El texto mide {longitud} carácteres");
            Console.WriteLine("");

            Console.Write("Introduzca una palabra a buscar en el texto: ");
            subcadena = Console.ReadLine();
            Console.WriteLine("");

            contieneSubcadena = procesador.contieneSubcadena(subcadena);
            comienzaPor = procesador.comienzaPor(subcadena);

            Console.WriteLine($"¿El texto contiene la subcadena ({ subcadena})?: {contieneSubcadena}");
            Console.WriteLine($"¿El texto comienza por la subcadena ({subcadena})?: {comienzaPor}");
            Console.WriteLine("");

            Console.Write("Introduzca un texto a comparar con el texto principal: ");
            otroTexto = Console.ReadLine();
            Console.WriteLine("");

            mismaLongitud = procesador.mismaLongitud(otroTexto);

            Console.WriteLine($"¿El texto mide lo mismo que el texto principal?: {mismaLongitud}");
            Console.WriteLine("");

            Console.Write("Introduzca un texto que remplazar con el texto principal: ");
            palabraRemplazar = Console.ReadLine();
            Console.Write("Introduzca la parte del texto que desea remplazar: ");
            textoRemplazar = Console.ReadLine();

            textoRemplazado = procesador.remplazarTexto(palabraRemplazar, textoRemplazar);

            Console.WriteLine($"Si remplazamos {textoRemplazar} por {palabraRemplazar}, el texto resultante será: {textoRemplazado}");
            Console.WriteLine("");

            Console.Write("Presione tecla para cerrar... ");
            Console.ReadLine();
        }
    }
}
