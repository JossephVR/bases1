using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.entidadesConsulta;

namespace WindowsFormsApp2.modelosConsultas
{
    public class modeloConsulta9
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public List<consulta9> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<consulta9> lista = new List<consulta9>();
            try
            {
                string sql = "SELECT Factura.fecha_factura AS Fecha, Factura.hora_factura AS Hora, Cliente.nombre AS Cliente, Cajero.nombre AS Cajero, Factura.precio_total AS Total_Ventas FROM Factura INNER JOIN Pedido ON Pedido.id_pedido = Factura.id_pedido INNER JOIN Cliente ON Cliente.id_cliente = Pedido.id_cliente INNER JOIN Cajero ON Cajero.id_cajero = Pedido.id_cajero;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    consulta9 d1 = new consulta9();
                    {
                        d1.Fecha = (DateTime)item["Fecha"];
                        d1.Hora = (TimeSpan)item["Hora"];
                        d1.Cliente = (string)item["Cliente"];
                        d1.Cajero = (string)item["Cajero"];
                        d1.Total_Ventas = (int)item["Total_Ventas"];


                    };
                    lista.Add(d1);
                }
                conex.Conn.Close();

            }
            catch (SqlException e)
            {
                ExisteError = true;
                MensajeError = e.Message;
            }
            return lista;
        }
    }
}
