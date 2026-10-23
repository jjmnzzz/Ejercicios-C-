using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte nota del exámen teórico: ");
            double notaTeorico;
            if(!double.TryParse(Console.ReadLine(), out notaTeorico) || notaTeorico < 0 || notaTeorico > 10)
            {
                Console.WriteLine("Nota no admitida por el sistema.");
                Console.WriteLine("");
                Console.WriteLine("Pulse cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            Console.Write("Inserte nota del exámen práctico: ");
            double notaPractico;
            if (!double.TryParse(Console.ReadLine(), out notaPractico) || notaPractico < 0 || notaPractico > 10)
            {
                Console.WriteLine("Nota no admitida por el sistema.");
                Console.WriteLine("");
                Console.WriteLine("Pulse cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            Console.Write("Inserte índice de asistencia (%): ");
            double asistencia;
            if (!double.TryParse(Console.ReadLine(), out asistencia) || asistencia < 0 || asistencia > 100)
            {
                Console.WriteLine("Porcentaje no admitido por el sistema.");
                Console.WriteLine("");
                Console.WriteLine("Pulse cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            NotaAlumno notaAlumno = new NotaAlumno(notaTeorico, notaPractico, asistencia);

            bool asistenciaSuficiente = notaAlumno.HaAprobadoAsistencia();
            if (asistenciaSuficiente == false)
            {
                Console.WriteLine("El alumno no cumple con la asistencia mínima del 80% (Suspenso por faltas).");
                Console.WriteLine("");
                Console.WriteLine("Pulse cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine($"El alumno tiene una nota total de {notaAlumno.NotaFinal()} así que saca un {notaAlumno.ObtenerCalificacion()}.");
                Console.WriteLine("");
            }

            Console.WriteLine("Pulse cualquier tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
