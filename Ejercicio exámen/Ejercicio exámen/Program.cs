using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_exámen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nombre
            Console.Write("Introduce nombre: ");
            string nombre = Console.ReadLine();

            if (string.IsNullOrEmpty(nombre) || nombre.Length < 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El campo no debe estar vacío y debe tener un mínimo de 6 letras.");
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            //DNI
            Console.Write("Introduce DNI: ");
            string dni = Console.ReadLine();
            int dniSinLetra;

            if (string.IsNullOrEmpty(dni) || dni.Length != 9 || !int.TryParse(dni.Remove(8, 1), out dniSinLetra))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El campo no debe estar vacío, debe tener 9 carácteres y los 8 primeros han de ser números.");
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            //Crear alumno
            Console.WriteLine("");
            Console.WriteLine("Creando el alumno/a...");
            Alumno alumno = new Alumno(nombre, dni); //Objeto de la clase Alumno
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alumno creado correctamente. ");
            Console.ResetColor();
            Console.WriteLine("");

            //Curso
            Console.Write("Introduzca nombre del curso (Alemán, Francés o Inglés): ");
            string curso = Console.ReadLine();

            if (!(curso.ToUpper() == "ALEMAN" || curso.ToUpper() == "ALEMÁN" || curso.ToUpper() == "FRANCES" || curso.ToUpper() == "FRANCÉS" || curso.ToUpper() == "INGLES" || curso.ToUpper() == "INGLÉS"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debe inscribirse a uno de los tres cursos ofrecidos.");
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Curso válido.");
                Console.ResetColor();
            }

            //Inscribir en curso
            Console.WriteLine("");
            Console.WriteLine("Inscribiendo en curso...");
            alumno.ApuntarCurso(curso);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alumno inscrito en curso correctamente. ");
            Console.ResetColor();
            Console.WriteLine("");

            //Fecha nacimiento
            Console.Write("Introduce la fecha de nacimiento: ");
            string fechaStr = Console.ReadLine();
            DateTime fechaNacimiento;
            
            if(!DateTime.TryParse(fechaStr, out fechaNacimiento) || fechaNacimiento > DateTime.Now)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La fecha introducida no es correcta.");
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            //Mostrar descuento y precio matrícula
            if (alumno.AplicarDescuento(fechaNacimiento) == true)
            {
                Console.WriteLine($"Descuento por ser menor de edad. Pagará la mitad. El precio será de {alumno.PrecioMatricula}");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"El precio será de {alumno.PrecioMatricula}");
                Console.WriteLine("");
            }

            
            //Precio abonado 
            Console.Write("¿Cuánto ha pagado ya de la mátricula?: ");
            string pagadoStr = Console.ReadLine();
            double pagado;

            if (!double.TryParse(pagadoStr, out pagado) || pagado < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El valor introducido no es válido.");
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.WriteLine("Presione cualquier tecla para finalizar...");
                Console.ReadKey();
                return;
            }

            //Ingresar dinero
            alumno.IngresarDinero(pagado);

            //Comprobar estado del pago
            if (alumno.HaPagadoTodo() == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("la matrícula ha sido completamente abonada.");
                Console.ResetColor();
                Console.WriteLine("");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aún no se ha pagado la matrícula completa.");
                Console.ResetColor();
                Console.WriteLine("");
            }

            //Mostrar datos
            Console.WriteLine($"{alumno.MostrarInformacion()}");
            Console.WriteLine("");

            //Comienzo curso
            if (alumno.CursoEmpezado() == true)
            {
                Console.WriteLine($"El curso ya ha comenzado, empezó el {alumno.InicioCurso.ToShortDateString()}");
            }
            else
            {
                if(alumno.DiasHastaComienzo() <= 31)
                {
                    Console.WriteLine($"Te queda poco para comenzar el curso, {alumno.DiasHastaComienzo()}");
                }
                else
                {
                    Console.WriteLine("Aún te queda por lo menos un mes para comenzar el curso.");
                }
            }

            //Finalizar programa
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();

        }
    }
}
