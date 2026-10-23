using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TicketParking
    {
        private int minutos;
        private bool esMapeoElectrico;
        public int Minutos
        {
            get
            {
                return minutos;
            }
            set
            {
                minutos = value;
            }
        }
        public bool EsMapeoElectrico
        {
            get
            {
                return esMapeoElectrico;
            }
            set
            {
                esMapeoElectrico = value;
            }
        }

        public TicketParking(int minutos, bool esMapeoElectrico)
        {
            this.minutos = minutos;
            this.esMapeoElectrico = esMapeoElectrico;
        }

        public double CalcularImporte()
        {
            double importe;

            if (minutos <= 30)
            {
                importe = 0;
            }
            else if (minutos <= 120)
            {
                importe = minutos * 0.05;
            }
            else
            {
                importe = minutos * 0.03;
            }

            if (esMapeoElectrico == true)
            {
                importe = importe * 0.8;
            }

            return importe;
        }

    }
}
