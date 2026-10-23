using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string usuarioCorrecto = "admin";
            const string contrasenaCorrecta = "miContraseña";
            bool sesionIniciada = false;

            while (sesionIniciada == false)
            {
                Console.Write("Inserte un usuario: ");
                string usuario = Console.ReadLine();

                if (string.IsNullOrEmpty(usuario))
                {
                    Console.WriteLine("El usuario no debe estar vacío.");
                    Console.WriteLine("");
                    continue;
                }

                Console.Write("Inserte una contraseña: ");
                string contrasena = Console.ReadLine();

                if (string.IsNullOrEmpty(contrasena))
                {
                    Console.WriteLine("la contraseña no debe estar vacía.");
                    Console.WriteLine("");
                    continue;
                }

                if (usuario.ToUpper() != usuarioCorrecto.ToUpper() && contrasena != contrasenaCorrecta)
                {
                    Console.WriteLine("Inicio de sesión fallido.");
                    Console.WriteLine("");
                    continue;
                }
                else if (usuario.ToUpper() != usuarioCorrecto.ToUpper())
                {
                    Console.WriteLine("Usuario incorrecto.");
                    Console.WriteLine("");
                    continue;
                }
                else if (contrasena != contrasenaCorrecta)
                {
                    Console.WriteLine("Contraseña incorrecta.");
                    Console.WriteLine("");
                    continue;
                }
                else
                {
                    sesionIniciada = true;
                    Console.WriteLine("Inicio de sesión correcto ¡Bienvenido!.");
                    Console.WriteLine("");                    
                }
            }

            Console.WriteLine("Pulse cualquier tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
