using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace P02Personas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 01

            /*string nombre;
            string apellido1;
            string apellido2;

            Console.WriteLine("Buenas");
            
            Console.Write("¿Cuál es tu nombre?: ");
            nombre = Console.ReadLine();

            Console.Write("¿Cuál es tu primer apellido?: ");
            apellido1 = Console.ReadLine();

            Console.Write("¿Cuál es tu segundo apellido?: ");
            apellido2 = Console.ReadLine();

            
            Console.WriteLine($"Buenas, {nombre} {apellido1} {apellido2}."); */

            //Ejercicio 02

            Persona persona1; 
            Persona persona2;
            Persona persona3;

            persona1 = new Persona();

            Console.Write("Nombre de la primera persona: ");
            persona1.Nombre = Console.ReadLine();
            Console.Write("Apellido de la primera persona: ");
            persona1.Apellido1 = Console.ReadLine();
            Console.Write("Segundo apellido de la primera persona: ");
            persona1.Apellido2 = Console.ReadLine();

            persona2 = new Persona();

            Console.Write("Nombre de la segunda persona: ");
            persona2.Nombre = Console.ReadLine();
            Console.Write("Apellido de la segunda persona: ");
            persona2.Apellido1 = Console.ReadLine();
            Console.Write("Segundo apellido de la segunda persona: ");
            persona2.Apellido2 = Console.ReadLine();

            persona3 = new Persona();

            Console.Write("Nombre de la tercera persona: ");
            persona3.Nombre = Console.ReadLine();
            Console.Write("Apellido de la tercera persona: ");
            persona3.Apellido1 = Console.ReadLine();
            Console.Write("Tercer apellido de la tercera persona: ");
            persona3.Apellido2 = Console.ReadLine();

            Console.WriteLine($"{persona1.Nombre} {persona1.Apellido1} {persona1.Apellido2}, {persona2.Nombre} {persona2.Apellido1} {persona2.Apellido2} y {persona3.Nombre} {persona3.Apellido1} {persona3.Apellido2}."); 
            
        }
    }
}
