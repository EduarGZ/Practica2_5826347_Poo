using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_5826347
{
    internal class Contado : Venta
    {
        public static int n;
        public Contado()
        {
            n++;
        }
        public int getN()
        {
            return n;
        }
        //Metodos de la clase contado
        public double calculaDescuento(double subtotal)
        {
            if(subtotal < 1000)
            {
                return 2.0 / 100 * subtotal;
            }
            else if (subtotal >= 1000 && subtotal <= 3000)
            {
                return 5.0 / 100 * subtotal;
            }
            else
            {
                return 12.0 / 100 * subtotal;
            }
        }

        public double calculaNeto(double subtotal,double descuento)
        {
            return subtotal - descuento;
        }
    }
}
