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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class agregarCliente : Form
    {
        public agregarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controladorClienteSuper clienteSuper= new controladorClienteSuper();
            cliente c1 = new cliente();
            c1.cedula_cliente = cajaCedula.Text;
            c1.nombre = cajaNombre.Text;
            c1.sexo = cajaSexo.Text;
            clienteSuper.Crear(c1);

            cajaC.Text = "se ha creado el cliente y se ha actualizado la lista";

            List<cliente> feel = clienteSuper.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "id: " + feel[i].id_cliente
                + " | cedula: " + feel[i].cedula_cliente
                + " | nombre: " + feel[i].nombre
                 + " | sexo: " + feel[i].sexo;

                showList.Items.Add(sg);

            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            controladorClienteSuper clienteSuper = new controladorClienteSuper();

            List<cliente> feel = clienteSuper.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "id: " + feel[i].id_cliente
                + " | cedula: " + feel[i].cedula_cliente
                + " | nombre: " + feel[i].nombre
                 + " | sexo: " + feel[i].sexo;

                showList.Items.Add(sg);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controladorClienteSuper clienteSuper = new controladorClienteSuper();
            int a = Int32.Parse(cajaId.Text);
            clienteSuper.Eliminar(a);
            cajaC.Text = "se ha borrado el cliente y se ha actualizado la lista";

            List<cliente> feel = clienteSuper.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "id: " + feel[i].id_cliente
                + " | cedula: " + feel[i].cedula_cliente
                + " | nombre: " + feel[i].nombre
                 + " | sexo: " + feel[i].sexo;

                showList.Items.Add(sg);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            controladorClienteSuper clienteSuper = new controladorClienteSuper();
            cliente c1 = new cliente();
            int a = Int32.Parse(cajaId.Text);
            c1.cedula_cliente = cajaCedula.Text;
            c1.nombre = cajaNombre.Text;
            c1.sexo = cajaSexo.Text;
            clienteSuper.Actulizar(c1, a);

            cajaC.Text = "se ha actualizado el cliente y tambien la lista";

            List<cliente> feel = clienteSuper.Obtener();

            showList.Items.Clear();

            for (int i = 0; i < feel.Count; i++)
            {
                string sg = "id: " + feel[i].id_cliente
                + " | cedula: " + feel[i].cedula_cliente
                + " | nombre: " + feel[i].nombre
                 + " | sexo: " + feel[i].sexo;

                showList.Items.Add(sg);

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
