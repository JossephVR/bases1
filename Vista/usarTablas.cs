using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Vista
{
    public partial class usarTablas : Form
    {
        public usarTablas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (agregarCliente c1 = new agregarCliente())
                c1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (vistaDepartamento c1 = new vistaDepartamento())
                c1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (vistaMarca c1 = new vistaMarca())
                c1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (vistaProveedor c1 = new vistaProveedor())
                c1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (vistaArticuloSuper c1 = new vistaArticuloSuper())
                c1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (vistaGerente c1 = new vistaGerente())
                c1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (vistaSucursal c1 = new vistaSucursal())
                c1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (vistaCajero c1 = new vistaCajero())
                c1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (vistaCaja c1 = new vistaCaja())
                c1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (vistaaEstanteria c1 = new vistaaEstanteria())
                c1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            using (vistaPasillo c1 = new vistaPasillo())
                c1.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (vistaPedido c1 = new vistaPedido())
                c1.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            using (vistaFactura c1 = new vistaFactura())
                c1.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            using (vistaInventario c1 = new vistaInventario())
                c1.ShowDialog();
        }
    }
}
