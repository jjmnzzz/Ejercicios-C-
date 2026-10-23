using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CursoAcademico
    {
        private DateTime fechaI;
        private DateTime fechaF;
        private DateTime fechaI_con_hora;
        private DateTime fechaF_con_hora;
        private TimeSpan duracionCurso;
        private int diasTotales;
        private DateTime semanaCultural;
        DateTime hoy = DateTime.Now;
        private TimeSpan hastaFecha;
        private int hastaFechaDias;

        public int HastaFechaDias
        {
            get
            {
                return hastaFechaDias;
            }
            set
            {
                hastaFechaDias = value;
            }
        }

        public TimeSpan HastaFecha
        {
            get
            {
                return hastaFecha;
            }
            set
            {
                hastaFecha = value;
            }
        }

        public int DiasTotales
        {
            get
            {
                return diasTotales;
            }
            set
            {
                diasTotales = value;
            }
        }

        public DateTime FechaI
        {
            get
            {
                return fechaI;
            }
            set
            {
                fechaI = value;
            }
        }

        public DateTime FechaF
        {
            get
            {
                return fechaF;
            }
            set
            {
                fechaF = value;
            }
        }

        public TimeSpan DuracionCurso
        {
            get
            {
                return duracionCurso;
            }
            set
            {
                duracionCurso = value;
            }
        }

        public DateTime SemanaCultural
        {
            get
            {
                return semanaCultural;
            }
            set
            {
                semanaCultural = value;
            }
        }

        public CursoAcademico(DateTime fecha1, DateTime fecha2, DateTime fecha3)
        {
            fechaI = fecha1; 
            fechaF = fecha2; 
            duracionCurso = fechaF - fechaI;
            diasTotales = (int)duracionCurso.TotalDays;
            
            semanaCultural = fecha3;
            hastaFecha = semanaCultural - hoy;
            hastaFechaDias = (int)hastaFecha.TotalDays;
        }
       

        public string diaDeLaSemana(DateTime fecha)
        {
            CultureInfo culturaEs = new CultureInfo("es-Es");
            return fecha.ToString("dddd", culturaEs);
        }

        public void AjustarHorarioInicio(double hora)
        {
            fechaI = fechaI.AddHours(hora);
        }

        public void AjustarHorarioFindeCurso(double hora)
        {
            fechaF = fechaI.AddHours(hora);
        }

    }
}
