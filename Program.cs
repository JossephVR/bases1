using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErpTEC.AccesoDatos;
using ErpTEC.Controlador;
using WindowsFormsApp2.controlador;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;
using WindowsFormsApp2.controladoresConsultas;
using WindowsFormsApp2.entidadesConsulta;

namespace WindowsFormsApp2
{

    
    internal static class Program


    {


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            /*
            ControladorCliente articulo = new ControladorCliente();
            Articulo a1 = new Articulo();
            a1.Articulo_id = 5;
            articulo.Crear(a1);

            ControladorCliente articulo2 = new ControladorCliente();
            Articulo a2 = new Articulo();
            a2.Articulo_id =122;
            articulo2.Crear(a2);

            ControladorCajero cajero = new ControladorCajero();
            cajero c1 = new cajero();
            c1.id_cajero = 747;
            c1.cedula = "20";
            c1.nombre = "Alvin Yakitori";
            cajero.Crear(c1);
            Application.Run(new Form1());

            */
            /*

            ControladorPersona persona = new ControladorPersona();
            persona p1 = new persona();
            p1.id = 747;
            persona.Crear(p1);
            Application.Run(new Form1());*/

            /*
            ControladorVehiculo vehiculo = new ControladorVehiculo();
            vehiculo v1 = new vehiculo();
            v1.id = 78;
            v1.nombre = "Camion";
            vehiculo.Crear(v1);*/

            /*  controladorClienteSuper cliente = new controladorClienteSuper();
              cliente c1 = new cliente();
              c1.cedula_cliente = "1000";
              c1.nombre = "YoXd";
              c1.sexo = "M";
              cliente.Crear(c1);

              controladorClienteSuper cliente2 = new controladorClienteSuper();
              cliente c2 = new cliente();
              c2.cedula_cliente = "1100";
              c2.nombre = "basta";
              c2.sexo = "M";

              cliente2.Actulizar(c2, 1);

             cliente2.Eliminar(102);*/

            /*controladorDepartamento departamento1 = new controladorDepartamento();
            departameto d1 = new departameto();
            d1.nombre = "aviones";
            departamento1.Crear(d1);*/

            /*
            modeloFactura f1 = new modeloFactura();

            factura d1 = new factura();

            int o = 12;

            int a = 1;
            int b = 1;
            int c = 1;

            DateTime d = DateTime.Today;

            string gg = "00:00:00";

            TimeSpan ec = TimeSpan.Parse(gg); 

            d1.fecha_factura = d;
            d1.hora_factura = ec;
            d1.id_pedido = a;
            d1.id_cliente = b;
            d1.precio_total = c;

            f1.Actulizar(d1, o);*/
            /*
            controladorAgregarPedido ja1 = new controladorAgregarPedido();

            agregarPedido a1 = new agregarPedido();

            a1.id_cliente = 1;

            a1.id_cajero = 1;

            a1.id_articulo = 1;

            a1.cantidad_articulo = 1;

            ja1.Crear(a1);

            */
            Application.Run(new Form1());
            

        }
    }
}
