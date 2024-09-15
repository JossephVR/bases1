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
    public class modeloArticuloSuper
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(articuloSuper p1)
        {
            Conexion conex = new Conexion();
            try
            {
                String sql = "INSERT INTO Articulo("
                        + "nombre, categoria, precio, id_proveedor"
                        + ")"
                        + " VALUES ('" + p1.nombre
                        + "', '" + p1.categoria
                        + "', '" + p1.precio
                        + "', '" + p1.id_proveedor
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

        public List<articuloSuper> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<articuloSuper> lista = new List<articuloSuper>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Articulo ORDER BY id_articulo ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    articuloSuper d1 = new articuloSuper();
                    {
                        d1.id_articulo = (int)item["id_articulo"];
                        d1.nombre = (string)item["nombre"];
                        d1.categoria = (string)item["categoria"];
                        d1.precio = (int)item["precio"];
                        d1.id_proveedor = (int)item["id_proveedor"];

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

        public void Actulizar(articuloSuper d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {
                string sql = "update Articulo Set nombre = '" + d1.nombre
                 + "', categoria = '" + d1.categoria
                 + "', precio = '" + d1.precio
                 + "', id_proveedor = '" + d1.id_proveedor
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
                String sql = "DELETE FROM Articulo"
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
