using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_5826347
{
    internal class Credito: Venta
    {
        public static int x;
        public Credito()
        {
            x++;
        }
        public int getx()
        {
            return x;
        }
        //Atributos de la clase Crédito
        public int letras { get; set; }

        //Metodos de la clase Credito
        public double calculaMontoInteres()
        {
            switch (letras)
            {
                case 3: return 5.0 / 100 * calculaSubtotal();
                case 6: return 10.0 / 100 * calculaSubtotal();
                case 9: return 15.0 / 100 * calculaSubtotal();
                case 12: return 25.0 / 100 * calculaSubtotal();
            }
            return 0;
        }

        public double calculaMontoMensual()
        {
            return (calculaSubtotal() + calculaMontoInteres())/letras;
        }

    }
}
