using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.Entidades;

namespace WindowsFormsApp2.Modelo
{
    public class modeloVehiculo
    {

        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(vehiculo v1)
        {
            Conexion conex = new Conexion();
            try
            {
                String sql = "INSERT INTO vehiculo("
                        + "id, nombre"
                        + ")"
                        + " VALUES ('" + v1.id + "' , '"
                        + v1.nombre
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

        public List<vehiculo> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<vehiculo> lista = new List<vehiculo>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                String sql = "SELECT * FROM vehiculo ORDER BY id ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    vehiculo v1 = new vehiculo
                    {
                        id = (int)item["id"],
                        nombre = (String)item["nombre"]
                    };
                    lista.Add(v1);
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
