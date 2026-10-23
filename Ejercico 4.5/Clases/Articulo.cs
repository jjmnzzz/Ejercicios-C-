using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Articulo
    {
        private double precioInicial;
        private double precioConDescuento;
        public double calcularPrecio(double pvp, int cantidad, double iva)
        {
            precioInicial = (pvp + (pvp * iva)) * cantidad;
            return Math.Round(precioInicial, 2);
        }

        public double aplicarDescuento(double descuento)
        {
            descuento = descuento / 100;
            precioConDescuento = precioInicial - (precioInicial * descuento);
            return Math.Round(precioConDescuento, 2);
        }
    }

}
