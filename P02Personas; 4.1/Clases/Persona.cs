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
        private string apellido1;
        private string apellido2; //variable (campo) privado

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Apellido1
        {
            get
            {
                return apellido1;
            }
            set
            {
                apellido1 = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }
            set
            {
                apellido2 = value;
            }
        }
    }
}
