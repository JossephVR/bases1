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
    public class modeloCaja
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(caja p1)
        {
            Conexion conex = new Conexion();
            try
            {//id_cajero, estado
                String sql = "INSERT INTO Caja("
                        + "id_cajero, estado"
                        + ")"
                        + " VALUES ('" + p1.id_cajero
                        + "', '" + p1.estado
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

        public List<caja> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<caja> lista = new List<caja>();
            try
            {//id_cajero, estado
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Caja ORDER BY id_caja ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    caja d1 = new caja();
                    {
                        d1.id_caja = (int)item["id_caja"];
                        d1.id_cajero = (int)item["id_cajero"];
                        d1.estado = (string)item["estado"];

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

        public void Actulizar(caja d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {
                string sql = "update Caja Set id_cajero = '" + d1.id_cajero
                 + "', estado = '" + d1.estado
                 + "' Where id_caja = '" + id + "';";

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
                String sql = "DELETE FROM Caja"
                         + " WHERE id_caja=" + id + " ;";
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
