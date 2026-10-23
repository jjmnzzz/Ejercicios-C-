using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ProcesadorTexto
    {
        private string texto;

        public string Texto
        {
            get
            {
                return texto;
            }
            set
            {
                texto = value;
            }
        }

        public ProcesadorTexto(string texto)
        {
            this.texto = texto;
        }

        public string obtenerMayusculas()
        {
            return texto.ToUpper();
        }

        public string obtenerMinusculas()
        {
            return texto.ToLower();
        }

        public int Longitud()
        {
            return texto.Length;
        }

        public bool contieneSubcadena(string subcadena)
        {
            return texto.Contains(subcadena);
        }

        public bool comienzaPor(string subcadena)
        {
            return texto.StartsWith(subcadena);
        }

        public bool mismaLongitud(string otroTexto)
        {
            return texto.Length == otroTexto.Length;
        }

        public string remplazarTexto(string palabraRemplazar, string textoRemplazar)
        {
            return texto.Replace(textoRemplazar, palabraRemplazar);
        }
    }
}
