using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.controladoresConsultas;
using WindowsFormsApp2.entidadesConsulta;

namespace WindowsFormsApp2.Vista
{
    public partial class hacerPedido : Form
    {

        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public hacerPedido()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)


        {
            int a = Int32.Parse(cajaIdCliente.Text);
            int b = Int32.Parse(cajaIdCajero.Text);
            int c = Int32.Parse(cajaIdArticulo.Text);
            int d = Int32.Parse(cajaaCantidad.Text);


            controladorAgregarPedido ja1 = new controladorAgregarPedido();

            agregarPedido a1 = new agregarPedido();

            a1.id_cliente = a;

            a1.id_cajero = b;

            a1.id_articulo = c;

            a1.cantidad_articulo = d;

            ja1.Crear(a1);

            cajaCon.Text = "Se ha realizado el pedido, puee verificarlo en las tablas";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (agregarCliente c1 = new agregarCliente())
                c1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (vistaCajero c1 = new vistaCajero())
                c1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (vistaArticuloSuper c1 = new vistaArticuloSuper())
                c1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (vistaPedido c1 = new vistaPedido())
                c1.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (vistaFactura c1 = new vistaFactura())
                c1.ShowDialog();
        }
    }
}
