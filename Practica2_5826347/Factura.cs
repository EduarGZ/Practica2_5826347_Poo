using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2_5826347
{
    internal class Factura
    {
        //Declaración de atributos privados
        private int _numFactura;
        private DateTime _fechaFact;
        private double _montoFact;

        static private double acumulado;
        static private int n;

        //Método constructor con parámetros
        public Factura(int numFactura, DateTime fechaFact, double montoFact)
        {
            this._numFactura = numFactura;
            this._fechaFact = fechaFact;
            this._montoFact = montoFact;
            n++;
        }
        //Metodos Gets

        public int numFactura
        {
            get { return _numFactura; }
        }

        public DateTime fechaFact
        {
            get { return _fechaFact; }
        }

        public double montoFact
        {
            get { return _montoFact; }
        }

        public int totalFacturas()
        {
            return n;
        }

        public double calculaTotalSubtotal()
        {
            return acumulado;
        }
        
        public double calculaComision()
        {
            return 0.12 * calculaTotalSubtotal();
        }
    }
}
