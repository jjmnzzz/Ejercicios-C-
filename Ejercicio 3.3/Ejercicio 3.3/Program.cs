using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Ejercicio_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DateTime fechaInicio;
            DateTime fechaFinal;
            String diaSemana1;
            String diaSemana2;
            DateTime semanaCultural;
            DateTime hoy = DateTime.Now;
            int dia;
            int mes;
            int ano;
            double hora1;
            double hora2;

            Console.Write("¿Cuándo comienza el curso?: ");
            DateTime.TryParse(Console.ReadLine(), out fechaInicio);
            
            Console.Write("¿Cuándo finaliza el curso?: ");
            DateTime.TryParse(Console.ReadLine(), out fechaFinal);

            Console.Write("¿Cuándo es la semana cultural?: ");
            DateTime.TryParse(Console.ReadLine(), out semanaCultural);

            dia = semanaCultural.Day;
            mes = semanaCultural.Month;
            ano = semanaCultural.Year;

            CursoAcademico calendario = new CursoAcademico(fechaInicio, fechaFinal, semanaCultural);
            
            diaSemana1 = calendario.diaDeLaSemana(fechaInicio);
            diaSemana2 = calendario.diaDeLaSemana(fechaFinal);

            Console.WriteLine($"Si el curso empezó {calendario.FechaI.ToShortDateString()} y acaba el {calendario.FechaF.ToShortDateString()}, ");
            Console.WriteLine($"entonces dura: {calendario.DiasTotales} días. ");
            Console.WriteLine($"El dia de inicio cae en {diaSemana1} y el dia final cae en {diaSemana2}.");
            Console.WriteLine($"La semana cultural comienza el {semanaCultural.ToShortDateString()} y hoy es {hoy.ToShortDateString()}.");
            Console.WriteLine($"Dia: " + dia + ", Mes: " + mes + ", Año: " + ano);
            Console.WriteLine($"Entonces quedan: {calendario.HastaFechaDias} días.");
            Console.WriteLine($"Fecha semana cultural formato corto: {semanaCultural.ToShortDateString()}");
            Console.WriteLine($"Fecha semana cultural formato largo: {semanaCultural.ToLongDateString()}");

            Console.Write("¿Inserte hora de comienzo de curso (HH,mm) ?: ");
            Double.TryParse(Console.ReadLine(), out hora1);

            Console.Write("¿Inserte hora de final de curso (HH,mm) ?: ");
            Double.TryParse(Console.ReadLine(), out hora2);

            calendario.AjustarHorarioInicio(hora1);
            calendario.AjustarHorarioFindeCurso(hora2);

            Console.WriteLine();
            Console.WriteLine($"El curso comienza el {calendario.FechaI}. ");
            Console.WriteLine($"El curso acaba el {calendario.FechaF}. ");

            Console.ReadLine();
        }
    }
}

