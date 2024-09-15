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
    public class modeloEstanteria
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(estanteria p1)
        {
            Conexion conex = new Conexion();
            try
            {//capacidad,categoria_productos
                String sql = "INSERT INTO Estanteria("
                        + "capacidad,categoria_productos"
                        + ")"
                        + " VALUES ('" + p1.capacidad
                        + "', '" + p1.categoria_productos
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

        public List<estanteria> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<estanteria> lista = new List<estanteria>();
            try
            {//capacidad,categoria_productos
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Estanteria ORDER BY id_estanteria ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    estanteria d1 = new estanteria();
                    {
                        d1.id_estanteria = (int)item["id_estanteria"];
                        d1.capacidad = (int)item["capacidad"];
                        d1.categoria_productos = (string)item["categoria_productos"];

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

        public void Actulizar(estanteria d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {
                string sql = "update Estanteria Set capacidad = '" + d1.capacidad
                 + "', categoria_productos = '" + d1.categoria_productos
                 + "' Where id_estanteria = '" + id + "';";

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
                String sql = "DELETE FROM Estanteria"
                         + " WHERE id_estanteria=" + id + " ;";
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
