using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_5826347
{
    internal class Venta
    {
        //Atributos
        public String cliente { get; set; }
        public String ruc { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public String producto { get; set; }
        public int cantidad { get; set; }

        //Metodos de la clase Venta
        public double asignaPreciio()
        {
            switch (producto)
            {
                case "Lavadora": return 1500;
                case "Refrigeradora": return 3500;
                case "Licuadora": return 500;
                case "Extractora": return 150;
                case "Radiograbadora": return 750;
                case "DVD": return 100;
                case "BluRay": return 250;
            }
            return 0;
        }
        //Metodo que calcula el subtotal
        public double calculaSubtotal()
        {
            return asignaPreciio() * cantidad;
        }
    }
}
