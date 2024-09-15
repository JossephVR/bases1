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
    public class modeloGerente
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(gerente p1)
        {
            Conexion conex = new Conexion();
            try
            {
                String sql = "INSERT INTO Gerente("
                        + "cedula, nombre, departamento_gerente"
                        + ")"
                        + " VALUES ('" + p1.cedula
                        + "', '" + p1.nombre
                        + "', '" + p1.departamento_gerente
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

        public List<gerente> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<gerente> lista = new List<gerente>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Gerente ORDER BY id_gerente ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    gerente d1 = new gerente();
                    {
                        d1.id_gerente = (int)item["id_gerente"];
                        d1.cedula = (string)item["cedula"];
                        d1.nombre = (string)item["nombre"];
                        d1.departamento_gerente = (int)item["departamento_gerente"];

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

        public void Actulizar(gerente d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {
                string sql = "update Gerente Set cedula = '" + d1.cedula
                 + "', nombre = '" + d1.nombre
                 + "', departamento_gerente = '" + d1.departamento_gerente
                 + "' Where id_gerente = '" + id + "';";

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
                String sql = "DELETE FROM Gerente"
                         + " WHERE id_gerente=" + id + " ;";
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
