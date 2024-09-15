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
    public class modeloPasillo
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(pasillo p1)
        {
            Conexion conex = new Conexion();
            try
            {//id_cajero, estado
                String sql = "INSERT INTO Pasillo("
                        + "estanteria_pasillo"
                        + ")"
                        + " VALUES ('" + p1.estanteria_pasillo
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

        public List<pasillo> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<pasillo> lista = new List<pasillo>();
            try
            {//id_cajero, estado
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Pasillo ORDER BY id_pasillo ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    pasillo d1 = new pasillo();
                    {
                        d1.id_pasillo = (int)item["id_pasillo"];
                        d1.estanteria_pasillo = (int)item["estanteria_pasillo"];

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

        public void Actulizar(pasillo d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {
                string sql = "update Pasillo Set estanteria_pasillo = '" + d1.estanteria_pasillo
                 + "' Where id_pasillo = '" + id + "';";

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
                String sql = "DELETE FROM Pasillo"
                         + " WHERE id_pasillo=" + id + " ;";
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
