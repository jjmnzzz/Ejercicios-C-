using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Clases
{
    public class Tupla
    {
        
        private string cadena1;
        private string cadena2;

        public string Cadena1
        {
            get
            {
                return cadena1;
            }
            set
            {
                cadena1 = value;
            }
        }

        public string Cadena2
        {
            get
            {
                return cadena2;
            }
            set
            {
                cadena2 = value;
            }
        }

        public Tupla (string cad1, string cad2)
        {
            cadena1 = cad1;
            cadena2 = cad2;
        }

        public bool mismaLongitud()
        {
            return cadena1.Length == cadena2.Length;
        }

        public bool sonIguales()
        {
            return cadena1 == cadena2;
        }

        public bool sonIgualesEquals()
        {
            return cadena1.Equals(cadena2);
        }

        public bool sonIualesPeroEscritasDistintas()
        {
            return cadena1.ToUpper() == cadena2.ToUpper();
        }

        public string anadirCadena(int posicion, string textoNuevo)
        {
            return cadena1.Insert(posicion, textoNuevo);
        }

        public bool cadena1ContieneACadena2(string cad2)
        {
            return (cadena1.ToUpper()).Contains(cad2.ToUpper());
        }

        public int primeraPosicionDeCadena2Encadena1(string cad2)
        {
            return (cadena1.ToUpper()).IndexOf((cad2.ToUpper()));
        }
        public int segundaPosicionDeCadena2Encadena1(string cad2)
        {
            int primeraPosicion = (cadena1.ToUpper()).IndexOf(cad2.ToUpper());
            return (cadena1.ToUpper()).IndexOf((cad2.ToUpper()), primeraPosicion + 1); 
        }

        public string recortar(int posicionRecortar, int cantidadRecortar)
        {
            return cadena1.Remove(posicionRecortar, cantidadRecortar);
        }
    }
}
