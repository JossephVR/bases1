using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.Entidades;

namespace WindowsFormsApp2.Modelo
{
    public class modeloFactura
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(factura p1)
        {
            Conexion conex = new Conexion();
            try
            {//fecha_factura, hora_factura, id_pedido, id_cliente, precio_total
                String sql = "INSERT INTO Factura("
                        + "fecha_factura, hora_factura, id_pedido, id_cliente, precio_total"
                        + ")"
                        + " VALUES ('" + p1.fecha_factura
                        + "', '" + p1.hora_factura
                        + "', '" + p1.id_pedido
                        + "', '" + p1.id_cliente
                        + "', '" + p1.precio_total
                        + "');";

                SqlCommand sqlCommand = new SqlCommand(sql, conex.Conn);
                sqlCommand.ExecuteNonQuery();
                conex.Conn.Close();

            }
            catch (SqlException e)
            {
                ExisteError = true;
                MensajeError = e.Message;
            }
        }

        public List<factura> Obtener()
        {
            //fecha_pedido, hora_pedido, id_cliente,
            //id_cajero, id_articulo, cantidad_articulo
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<factura> lista = new List<factura>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Factura ORDER BY id_factura ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    factura d1 = new factura();
                    {//fecha_factura, hora_factura, id_pedido, id_cliente, precio_total
                        d1.id_factura = (int)item["id_factura"];
                        d1.fecha_factura = (DateTime)item["fecha_factura"];
                        d1.hora_factura = (TimeSpan)item["hora_factura"];
                        d1.id_pedido = (int)item["id_pedido"];
                        d1.id_cliente = (int)item["id_cliente"];
                        d1.precio_total = (int)item["precio_total"];
                      

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

        public void Actulizar(factura d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {//fecha_factura, hora_factura, id_pedido, id_cliente, precio_total
                string sql = "update Factura Set fecha_factura = '" + d1.fecha_factura
                 + "', hora_factura = '" + d1.hora_factura
                 + "', id_pedido = '" + d1.id_pedido
                 + "', id_cliente = '" + d1.id_cliente
                 + "', precio_total = '" + d1.precio_total
                 + "' Where id_factura = '" + id + "';";

                SqlCommand npgsqlCommand = new SqlCommand(sql, conex.Conn);
                npgsqlCommand.ExecuteNonQuery();
                conex.Conn.Close();

            }
            catch (SqlException e)
            {
                ExisteError = true;
                MensajeError = e.Message;
            }
        }

        public void Eliminar(int id)
        {
            Conexion conex = new Conexion();

            try
            {
                String sql = "DELETE FROM Factura"
                         + " WHERE id_factura=" + id + " ;";
                SqlCommand npgsqlCommand = new SqlCommand(sql, conex.Conn);
                npgsqlCommand.ExecuteNonQuery();
                conex.Conn.Close();

            }
            catch (SqlException e)
            {
                ExisteError = true;
                MensajeError = e.Message;
            }


        }
    }
}
