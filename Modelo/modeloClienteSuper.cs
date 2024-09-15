using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.Entidades;


namespace WindowsFormsApp2.Modelo
{
    internal class modeloClienteSuper
    {

        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(cliente c1)
        {
            Conexion conex = new Conexion();
            try
            {
                String sql = "INSERT INTO Cliente("
                        + "cedula_cliente, nombre, sexo"
                        + ")"
                        + " VALUES ('" + c1.cedula_cliente + "' , '"
                        + c1.nombre + "' , '"
                        + c1.sexo 
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

        public List<cliente> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<cliente> lista = new List<cliente>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Cliente ORDER BY id_cliente ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    cliente c1 = new cliente
                    {
                        id_cliente = (int)item["id_cliente"],
                        cedula_cliente = (string)item["cedula_cliente"],
                        nombre = (string)item["nombre"],
                        sexo = (string)item["sexo"]
                    };
                    lista.Add(c1);
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

        public void Actulizar(cliente c1, int id)
        {
            Conexion conex = new Conexion();

            try
            {
                string sql = "update Cliente Set cedula_cliente = '" + c1.cedula_cliente + "', "
                  + "nombre = '" + c1.nombre + "', sexo = '" + c1.sexo + "' Where id_cliente = '" + id + "';";
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
                String sql = "DELETE FROM Cliente"
                         + " WHERE id_cliente=" + id + " ;";
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

