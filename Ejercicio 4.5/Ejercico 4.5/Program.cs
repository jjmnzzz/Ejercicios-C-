using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Clases;

namespace Ejercico_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedir y comprobar PVP
            Console.Write("PVP: ");
            double pvp;
            if(!double.TryParse(Console.ReadLine(), out pvp))
            {
                Console.WriteLine("Tipo de dato introducido no aceptado.");
                Console.WriteLine("");
                Console.WriteLine("Pulse cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            //Pedir y comprobar cantidad
            Console.Write("Cantidad: ");
            int cantidad;
            if (!int.TryParse(Console.ReadLine(), out cantidad))
            {
                Console.WriteLine("Tipo de dato introducido no aceptado.");
                Console.WriteLine("");
                Console.WriteLine("Pulse cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            //Pedir tipo de Iva y asignar Iva
            Console.Write("Iva (General/Reducido/Superreducido): ");
            string tipoIva = Console.ReadLine().ToUpper();
            double iva;
            if (tipoIva == "GENERAL" || tipoIva == "REDUCIDO" || tipoIva == "SUPERREDUCIDO")
            {
                if (tipoIva == "GENERAL")
                {
                    iva = 0.21;
                }
                else if (tipoIva == "REDUCIDO")
                {
                    iva = 0.1;
                }
                else
                {
                    iva = 0.04;
                }
            }
            else
            {
                Console.WriteLine("Tipo de dato introducido no aceptado.");
                Console.WriteLine("");
                Console.WriteLine("Pulse cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            //Crear nuevo objeto
            Articulo articulo = new Articulo();

            //Calcula primer precio y lo escribe en consola
            double primerPrecio = articulo.calcularPrecio(pvp, cantidad, iva);
            Console.WriteLine($"El precio hasta ahora es {primerPrecio}€, veamos si hay algún descuento. ");

            //Comprobar si es elegible a descuento
            Console.Write("¿Estudia o trabaja en eduación(S/N)?: ");
            string educacion = Console.ReadLine().ToUpper();
            bool tieneDescuento;
            if (educacion == "S" || educacion == "N")
            {
                if (educacion == "S")
                {
                    tieneDescuento = true;
                }
                else
                {
                    tieneDescuento = false;
                }
            }
            else
            {
                Console.WriteLine("Tipo de dato introducido no aceptado (Debía introducir S o N).");
                Console.WriteLine("");
                Console.WriteLine("Pulse cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            //Descuento:
            double precioFinal;
            if (tieneDescuento == true) //En caso de tener descuento...
            {
                //pedir el descuento...
                Console.Write("Descuento(%): ");
                double descuento;
                if (!double.TryParse(Console.ReadLine(), out descuento))
                {
                    Console.WriteLine("Tipo de dato introducido no aceptado.");
                    Console.WriteLine("");
                    Console.WriteLine("Pulse cualquier tecla para finalizar...");
                    Console.ReadKey();
                    return;
                }
                //y aplicarlo.
                precioFinal = articulo.aplicarDescuento(descuento); 
            }
            else //En caso de no tener descuento...
            {
                //conservar precio inicial.
                precioFinal = primerPrecio; 
            }

            //Obtener precio total y mostrar en pantalla
            Console.WriteLine($"El precio final es: {precioFinal}€");

            Console.WriteLine("");
            Console.WriteLine("Pulse cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
