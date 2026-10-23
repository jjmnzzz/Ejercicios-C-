using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        
        public Persona(string nombre , DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int Anyos()
        {
            TimeSpan edad = DateTime.Now - fechaNacimiento;
            int anosTotales = (int)(edad.TotalDays / 365.25);
            return anosTotales;
        }
    }
}
