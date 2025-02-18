using System;
using System.Collections;
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
    public partial class frmContado : Form
    {
        //Inicialización del arreglo de productos
        static string[] productos = { "Lavadora", "Regrigeradora", "Licuadora", "Extractora", "Radiograbadora", "DVD", "BluRay" };

        //Creando el objeto de la clase ArrayList
        ArrayList aProductos = new ArrayList(productos);

        //Variable acumuladora de totales
        double tSubtotal = 0;
        public frmContado()
        {
            InitializeComponent();
        }

        private void lbtNeto_Click(object sender, EventArgs e)
        {

        }

        private void frmContado_Load(object sender, EventArgs e)
        {
            cboProductos.DataSource = aProductos;
            mostrarFecha();
            mostrarHora();
        }
        void mostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString(); 
        }
        void mostrarHora()
        {
            lblHora.Text = DateTime.Now.ToShortDateString();
        }
        void listado(Contado objc)
        {
            tSubtotal += objc.calculaSubtotal();
            lstResumen.Items.Clear();
            lstResumen.Items.Add("** RESUMEN DE VENTA **");
            lstResumen.Items.Add("-------------------------------");
            lstResumen.Items.Add("Cliente: " + objc.cliente);
            lstResumen.Items.Add("RUC: " + objc.ruc);
            lstResumen.Items.Add("FECHA: " + objc.fecha);
            lstResumen.Items.Add("HORA: " + objc.hora);
            lstResumen.Items.Add("--------------------------------");
            lstResumen.Items.Add("Subtotal: " + tSubtotal.ToString("C"));
            double descuento = objc.calculaDescuento(tSubtotal);
            double neto = objc.calculaNeto(tSubtotal, descuento);
            lstResumen.Items.Add("Descuento: " + descuento.ToString("C"));
            lstResumen.Items.Add("NETO: " + neto.ToString("C"));

            //Hallar el monto total sin descuento
            lbtNeto.Text = neto.ToString("C");
            
        }

        private void btnAdquirir_Click(object sender, EventArgs e)
        {
            //Objeto de la clase Contado
            Contado objc = new Contado();

            //Datos del cliente
            objc.cliente = txtCliente.Text;
            objc.ruc = txtRuc.Text;
            objc.fecha = DateTime.Parse(lblFecha.Text);
            objc.hora = DateTime.Parse(lblHora.Text);

            //Datos del producto
            objc.producto = cboProductos.Text;
            objc.cantidad = int.Parse(txtCantidad.Text);

            //Imprimiendo en la lista
            ListViewItem fila = new ListViewItem(objc.getN().ToString());
            fila.SubItems.Add(objc.producto);
            fila.SubItems.Add(objc.cantidad.ToString());
            fila.SubItems.Add(objc.asignaPreciio().ToString("C"));
            fila.SubItems.Add(objc.calculaSubtotal().ToString());
            lvDetalle.Items.Add(fila);
            listado(objc);
        }
    }
}
