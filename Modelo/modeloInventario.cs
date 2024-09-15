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
    public class modeloInventario
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(Inventario p1)
        {
            Conexion conex = new Conexion();
            try
            {//id_cajero, estado
                String sql = "INSERT INTO Inventario("
                        + "id_articulo, cantidad"
                        + ")"
                        + " VALUES ('" + p1.id_articulo
                        + "', '" + p1.cantidad
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

        public List<Inventario> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<Inventario> lista = new List<Inventario>();
            try
            {//id_cajero, estado
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Inventario ORDER BY id_articulo ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    Inventario d1 = new Inventario();
                    {
                        d1.id_articulo = (int)item["id_articulo"];
                        d1.cantidad = (int)item["cantidad"];
                       

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

        public void Actulizar(Inventario d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {
                string sql = "update Inventario Set id_articulo = '" + d1.id_articulo
                 + "', cantidad = '" + d1.cantidad
                 + "' Where id_articulo = '" + id + "';";

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
                String sql = "DELETE FROM Inventario"
                         + " WHERE id_articulo=" + id + " ;";
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
