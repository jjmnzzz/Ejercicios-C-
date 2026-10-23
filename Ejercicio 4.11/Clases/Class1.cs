using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Nutricion
    {
        private double peso;
        private double altura;
        private int edad;
        private double imc;
        public double Peso
        {
            get
            {
                return peso;
            }
            set
            {
                peso = value;  
            }
        }
        public double Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public Nutricion(double peso, double altura, int edad)
        {
            this.peso = peso;
            this.altura = altura;
            this.edad = edad;
        }

        public double CalcularIMC()
        {
            imc = (peso / Math.Pow(altura, 2));
            return Math.Round(imc, 2);
        }

        public string EstadoIMC()
        {
            string estado;
            if (imc < 18.5) 
            {
                return estado = "Bajo peso";
            }
            else if (imc < 25)
            {
                return estado = "Peso normal";
            }
            else if (imc < 30)
            {
                return estado = "Sobrepeso";
            }
            else
            {
                return estado = "Obesidad";
            }
        }

        public string RecomendacionMedica()
        {
            string recomendacion;
            if (imc >= 30 || edad > 65)
            {
                return recomendacion = "Ir a una revisión médica.";
            }
            else
            {
                return recomendacion = "ninguna.";
            }
        }

    }
}
