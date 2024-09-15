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

namespace WindowsFormsApp2.Vista
{
    public partial class vistaaEstanteria : Form
    {
        public vistaaEstanteria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controladorEstanteria d1 = new controladorEstanteria();
            List<estanteria> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "id: " + feel[i].id_estanteria
                + " | capacidad: " + feel[i].capacidad
                + " | categoria_productos: " + feel[i].categoria_productos;

                showList.Items.Add(sg);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controladorEstanteria depa = new controladorEstanteria();

            estanteria d1 = new estanteria();

            int a = Int32.Parse(cajaCap.Text);

            d1.capacidad= a;
            d1.categoria_productos = cajaCat.Text;


            depa.Crear(d1);

            controladorEstanteria d14 = new controladorEstanteria();
            List<estanteria> feel = d14.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "id: " + feel[i].id_estanteria
                + " | capacidad: " + feel[i].capacidad
                + " | categoria_productos: " + feel[i].categoria_productos;

                showList.Items.Add(sg);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controladorEstanteria depa = new controladorEstanteria();

            int a = Int32.Parse(cajaId.Text);

            depa.Eliminar(a);

            controladorEstanteria d1 = new controladorEstanteria();
            List<estanteria> feel = d1.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "id: " + feel[i].id_estanteria
                + " | capacidad: " + feel[i].capacidad
                + " | categoria_productos: " + feel[i].categoria_productos;

                showList.Items.Add(sg);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            controladorEstanteria depa = new controladorEstanteria();

            int a = Int32.Parse(cajaId.Text);

            int b = Int32.Parse(cajaCap.Text);

            estanteria d1 = new estanteria();

            d1.capacidad = b;

            d1.categoria_productos = cajaCat.Text;

            depa.Actulizar(d1, a);

            controladorEstanteria d14 = new controladorEstanteria();
            List<estanteria> feel = d14.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "id: " + feel[i].id_estanteria
                + " | capacidad: " + feel[i].capacidad
                + " | categoria_productos: " + feel[i].categoria_productos;

                showList.Items.Add(sg);

            }
        }
    }
}
