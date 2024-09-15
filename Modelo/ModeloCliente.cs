using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.Entidades;
//using System.Data.SqlClient;

namespace WindowsFormsApp2.Modelo
{
    public class ModeloCliente
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(Articulo articulo)
        {
            Conexion conex = new Conexion();
            try
            {
                String sql = "INSERT INTO Articulo1("
                        + "Articulo_id" + ")"
                        + " VALUES ('" + articulo.Articulo_id + "');";
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

        //np = sql;
        public List<Articulo> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<Articulo> lista = new List<Articulo>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                String sql = "SELECT * FROM Articulo1 ORDER BY id ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    Articulo articulo = new Articulo
                    {
                        Articulo_id = (int)item["id"]

                    };
                    lista.Add(articulo);
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

        /*

        public void Actulizar(Cliente cliente)
        {
            Conexion conex = new Conexion();

            try
            {
                String sql = "UPDATE cliente SET "
                        + " cedula ='" + cliente.Cedula + "',"
                        + " nombre ='" + cliente.Nombre + "',"
                        + " direccion='" + cliente.Direccion + "' "
                         + " WHERE id=" + cliente.Id + " ;";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, conex.Conn);
                npgsqlCommand.ExecuteNonQuery();
                conex.Conn.Close();

            }
            catch (NpgsqlException e)
            {
                ExisteError = true;
                MensajeError = e.Message;
            }
        }



        public void Eliminar(Cliente cliente)
        {
            Conexion conex = new Conexion();

            try
            {
                String sql = "DELETE FROM cliente"
                         + " WHERE id=" + cliente.Id + " ;";
                NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, conex.Conn);
                npgsqlCommand.ExecuteNonQuery();
                conex.Conn.Close();

            }
            catch (NpgsqlException e)
            {
                ExisteError = true;
                MensajeError = e.Message;
            }
        

        }*/
    }
    
    
}
