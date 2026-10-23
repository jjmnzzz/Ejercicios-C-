using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NotaAlumno
    {
        private double notaTeoria;
        private double notaPractica;
        private double asistencia;
        private double notaFinal;

        public double NotaTeoria
        {
            get
            {
                return notaTeoria;
            }
            set
            {
                notaTeoria = value;
            }
        }

        public double NotaPractica
        {
            get
            {
                return notaPractica;
            }
            set
            {
                notaPractica = value;
            }
        }

        public double Asistencia
        {
            get
            {
                return asistencia;
            }
            set
            {
                asistencia = value;
            }
        }

        public NotaAlumno(double teoria, double practica, double asistencia)
        {
            notaTeoria = teoria;
            notaPractica = practica;
            this.asistencia = asistencia;
        }

        public bool HaAprobadoAsistencia()
        {
            if (asistencia >= 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaFinal()
        {
            notaFinal = (notaTeoria * 0.4) + (notaPractica * 0.6);
            return notaFinal;
        }

        public string ObtenerCalificacion()
        {
            string calificacion;
            if (notaFinal < 5)
            {
                calificacion = "Insuficiente";
            }
            else if (notaFinal < 6)
            {
                calificacion = "Suficiente";
            }
            else if (notaFinal < 7)
            {
                calificacion = "Bien";
            }
            else if (notaFinal < 9)
            {
                calificacion = "Notable";
            }
            else
            {
                calificacion = "Sobresaliente";
            }

            return calificacion;
        }
    }
}
