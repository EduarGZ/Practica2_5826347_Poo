using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_5826347
{
    public partial class nada : Form
    {
        public nada()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Capturando los valores del formulario
            int numFactura = int.Parse(txtNumFact.Text);
            DateTime fechaFact = DateTime.Parse(txtFechaFact.Text);
            double montoFact = double.Parse(txtMontoFact.Text);

            //Objeto de la clase Factura
            Factura objF = new Factura(numFactura, fechaFact, montoFact);

            //Imprimiendo en la lista
            ListViewItem fila = new ListViewItem(objF.numFactura.ToString());
            fila.SubItems.Add(objF.fechaFact.ToShortDateString());
            fila.SubItems.Add(objF.montoFact.ToString("C"));
            lvFacturas.Items.Add(fila);

            //Mostrando los montos
            lblTotalFact.Text = objF.totalFacturas().ToString();
            lblTotalSub.Text = objF.calculaTotalSubtotal().ToString("C");
            lblComision.Text = objF.calculaComision().ToString("C");
        }

        private void nada_Load(object sender, EventArgs e)
        {
            lblFecha.Text = muestraFecha();
        }
        //Funcion lambda que muestra la fecha actual
        Func<String> muestraFecha = () => DateTime.Now.ToShortDateString();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
