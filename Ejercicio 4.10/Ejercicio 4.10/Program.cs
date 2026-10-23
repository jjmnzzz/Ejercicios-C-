using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_4._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Ingresar el número de tarjeta y comprobar su validez
            Console.Write("Ingrese número de tarjeta: ");
            string tarjeta = Console.ReadLine();
            if (string.IsNullOrEmpty(tarjeta))
            {
                Console.WriteLine("Debe introducir algun valor.");
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar... ");
                Console.ReadKey();
                return;
            }

            if (tarjeta.Length != 16)
            {
                Console.WriteLine("El valor introducido debe tener 16 carácteres.");
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar... ");
                Console.ReadKey();
                return;
            }

            if (int.TryParse(tarjeta, out int tarjetaNum))
            {
                Console.WriteLine("El valor introducido debe estar compuesto por números.");
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar... ");
                Console.ReadKey();
                return;
            }

            //Ingresar pin de tarjeta y comprobar su validez
            Console.Write("Ingrese el pin de la tarjeta: ");
            string pinTarjeta = Console.ReadLine();
            if (string.IsNullOrEmpty(pinTarjeta))
            {
                Console.WriteLine("Debe introducir algun valor.");
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar... ");
                Console.ReadKey();
                return;
            }

            //Instanciar objeto CajeroAutomatico
            CajeroAutomatico cajero = new CajeroAutomatico();

            //Validar pin
            bool datosCorrectos = cajero.ValidarPin(pinTarjeta, tarjeta);

            if (!datosCorrectos)
            {
                Console.WriteLine("Los datos de acceso son incorrectos.");
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar... ");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Los datos de acceso son correctos. Accediendo...");
            Console.WriteLine(" ");

            //Solicitar importe a retirar
            Console.WriteLine($"Saldo disponible: {cajero.SaldoDisponible}");
            Console.WriteLine("-------------------------------");
            Console.Write("Cuanto desea retirar: ");
            double dineroRetirar;
            if (!double.TryParse(Console.ReadLine(), out dineroRetirar))
            {
                Console.WriteLine("El valor introducido no es aceptado.");
                return;
            }
            cajero.SacarDinero(dineroRetirar);

            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para finalizar... ");
            Console.ReadKey();
        }
    }
}
