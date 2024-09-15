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
    public class modeloPedido
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(pedido p1)
        {
            Conexion conex = new Conexion();
            try
            {//fecha_pedido, hora_pedido, id_cliente,
             //id_cajero, id_articulo, cantidad_articulo
                String sql = "INSERT INTO Pedido("
                        + "fecha_pedido, hora_pedido, id_cliente, id_cajero, id_articulo, cantidad_articulo"
                        + ")"
                        + " VALUES ('" + p1.fecha_pedido
                        + "', '" + p1.hora_pedido
                        + "', '" + p1.id_cliente
                        + "', '" + p1.id_cajero
                        + "', '" + p1.id_articulo
                        + "', '" + p1.catidad_articulo
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

        public List<pedido> Obtener()
        {
            //fecha_pedido, hora_pedido, id_cliente,
            //id_cajero, id_articulo, cantidad_articulo
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<pedido> lista = new List<pedido>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Pedido ORDER BY id_pedido ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    pedido d1 = new pedido();
                    {//fecha_pedido, hora_pedido, id_cliente,
                     //id_cajero, id_articulo, cantidad_articulo
                        d1.id_pedido = (int)item["id_pedido"];
                        d1.fecha_pedido = (DateTime)item["fecha_pedido"];
                        d1.hora_pedido = (TimeSpan)item["hora_pedido"];
                        d1.id_cliente = (int)item["id_cliente"];
                        d1.id_cajero= (int)item["id_cajero"];
                        d1.id_articulo = (int)item["id_articulo"];
                        d1.catidad_articulo = (int)item["cantidad_articulo"];

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

        public void Actulizar(pedido d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {//fecha_pedido, hora_pedido, id_cliente,
             //id_cajero, id_articulo, cantidad_articulo
                string sql = "update Pedido Set fecha_pedido = '" + d1.fecha_pedido
                 + "', hora_pedido = '" + d1.hora_pedido
                 + "', id_cliente = '" + d1.id_cliente
                 + "', id_cajero = '" + d1.id_cajero
                 + "', id_articulo = '" + d1.id_articulo
                 + "', cantidad_articulo = '" + d1.catidad_articulo
                 + "' Where id_pedido = '" + id + "';";

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
                String sql = "DELETE FROM Pedido"
                         + " WHERE id_pedido=" + id + " ;";
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
