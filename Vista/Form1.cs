using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.controlador;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;
using WindowsFormsApp2.Vista;

namespace WindowsFormsApp2
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {


            modeloClienteSuper cliente = new modeloClienteSuper();
            cliente c2 = new cliente();
            c2.cedula_cliente = "287023";
            c2.nombre = "papayaXddd";
            c2.sexo = "M";
            cliente.Crear(c2);


            
            
            
        }

        private void caja_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (usarTablas c1 = new usarTablas())
                c1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (consultas c1 = new consultas())
                c1.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (hacerPedido c1 = new hacerPedido())
                c1.ShowDialog();

        }
    }
}
