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
using WindowsFormsApp2.controladoresConsultas;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.entidadesConsulta;

namespace WindowsFormsApp2.Vista
{
    public partial class consultas : Form
    {
        public consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controladorConsulta1 d1 = new controladorConsulta1();
            List<consulta1> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "nombre: " + feel[i].nombre
                + " | Cantidad_Vendida: " + feel[i].cantidad_vendida;



                showList.Items.Add(sg);

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controladorConsulta2 d1 = new controladorConsulta2();
            List<consulta2> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "Sucursal: " + feel[i].Sucursal
                + " | Total_ventas: " + feel[i].Total_Ventas;



                showList.Items.Add(sg);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controladorConsulta3 d1 = new controladorConsulta3();
            List<consulta3> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "Cajero: " + feel[i].Cajero
                + " | Total_ventas: " + feel[i].Total_Ventas;



                showList.Items.Add(sg);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            controladorConsulta4 d1 = new controladorConsulta4();
            List<consulta4> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "Cliente: " + feel[i].Cliente
                + " | Total_ventas: " + feel[i].Total_Ventas;



                showList.Items.Add(sg);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            controladorConsulta5 d1 = new controladorConsulta5();
            List<consulta5> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "Articulo: " + feel[i].Articulo
                + " | Total_ventas: " + feel[i].Total_Ventas;



                showList.Items.Add(sg);

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            controladorConsulta6 d1 = new controladorConsulta6();
            List<consulta6> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "Fecha: " + feel[i].Fecha
                + " | Hora: " + feel[i].Hora
                + " | Total_ventas: " + feel[i].Total_Ventas;

                showList.Items.Add(sg);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            controladorConsulta7 d1 = new controladorConsulta7();
            List<consulta7> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "Articulo: " + feel[i].Articulo
                + " | Total_ventas: " + feel[i].Total_Ventas
                + " | Total_Ganancias: " + feel[i].Total_Ganancias;

                showList.Items.Add(sg);

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            controladorConsulta8 d1 = new controladorConsulta8();
            List<consulta8> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "Proveedor: " + feel[i].Proveedor
                + " | Total_Articulos: " + feel[i].Total_Articulo;

                showList.Items.Add(sg);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            controladorConsulta9 d1 = new controladorConsulta9();
            List<consulta9> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "Fecha: " + feel[i].Fecha
                + " | Hora: " + feel[i].Hora
                + " | Cliente: " + feel[i].Cliente
                + " | Cajero: " + feel[i].Cajero
                + " | Total_Ventas: " + feel[i].Total_Ventas;

                showList.Items.Add(sg);

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            controladorConsulta10 d1 = new controladorConsulta10();
            List<consulta10> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "Articulo: " + feel[i].Articulo
                + " | Cantidad: " + feel[i].Cantidad;



                showList.Items.Add(sg);

            }
        }

        private void showList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
