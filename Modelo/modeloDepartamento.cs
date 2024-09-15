using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.Entidades;

namespace WindowsFormsApp2.Modelo
{
    public class modeloDepartamento
    {

        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(departameto d1)
        {
            Conexion conex = new Conexion();
            try
            {
                String sql = "INSERT INTO Departamento("
                        + "nombre"
                        + ")"
                        + " VALUES ('" + d1.nombre 
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

        public List<departameto> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<departameto> lista = new List<departameto>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Departamento ORDER BY id_dept ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    departameto d1 = new departameto();
                    {
                        d1.id_dept = (int)item["id_dept"];
                        d1.nombre = (string)item["nombre"];

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

        public void Actulizar(departameto d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {
                string sql = "update Departamento Set nombre = '" + d1.nombre 
                 +"' Where id_dept = '" + id + "';";

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
                String sql = "DELETE FROM Departamento"
                         + " WHERE id_dept=" + id + " ;";
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
