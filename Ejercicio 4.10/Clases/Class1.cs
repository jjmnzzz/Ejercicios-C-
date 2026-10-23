using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class CajeroAutomatico
    {
        private string numTarjeta = "1111222233334444";
        private string pinGuardado = "1234";
        private double saldoDisponible = 12000;

        public double SaldoDisponible
        {
            get
            {
                return saldoDisponible;
            }
            set
            {
                saldoDisponible = value;
            }
        }

        //Validar el pin
        public bool ValidarPin(string pinIngresado, string numTarjetaIngresado)
        {
            if (pinGuardado == pinIngresado && numTarjeta == numTarjetaIngresado)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void SacarDinero(double dineroRetirar)
        {           
            bool operacionPosible;
            if (dineroRetirar <= 0 || dineroRetirar > saldoDisponible || dineroRetirar % 10 != 0)
            {
                operacionPosible = false;
            }
            else
            {
                operacionPosible = true;
            }

            if (!operacionPosible)
            {
                Console.WriteLine("El valor introducido no es aceptado.");
                return;
            }
            else
            {
                saldoDisponible -= dineroRetirar;
                Console.WriteLine($"Retirando {dineroRetirar} euros...");
                Console.WriteLine(" ");
                Console.WriteLine($"El saldo ahora es de {saldoDisponible} euros.");
            }
        }
    }
}
