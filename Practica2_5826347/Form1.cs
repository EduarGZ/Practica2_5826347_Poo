using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_5826347
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCredito form2 = new frmCredito();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lvFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            frmCredito frmCre = new frmCredito();
            frmCre.Show();
        }

        private void btnContado_Click(object sender, EventArgs e)
        {
            frmContado frmC = new frmContado();
            frmC.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            nada nv = new nada();
            nv.Show();
        }
    }
}
