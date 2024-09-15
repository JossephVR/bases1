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
    public class modeloCajero
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(cajero d1)
        {
            Conexion conex = new Conexion();
            try
            {
                //cedula, nombre, id_sucursal
                String sql = "INSERT INTO Cajero("
                        + "cedula, nombre, id_sucursal"
                        + ")"
                        + " VALUES ('" + d1.cedula
                        + "', '" + d1.nombre
                        + "', '" + d1.id_sucursal
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

        public List<cajero> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<cajero> lista = new List<cajero>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Cajero ORDER BY id_cajero ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    cajero d1 = new cajero();
                    {
                        ////cedula, nombre, id_sucursal

                        d1.id_cajero = (int)item["id_cajero"];
                        d1.cedula = (string)item["cedula"];
                        d1.nombre = (string)item["nombre"];
                        d1.id_sucursal = (int)item["id_sucursal"];
                        

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

        public void Actulizar(cajero d1, int id)
        {
            Conexion conex = new Conexion();

            try
            { ////cedula, nombre, id_sucursal
                string sql = "update Cajero Set cedula = '" + d1.cedula
                 + "', nombre = '" + d1.nombre
                 + "', id_sucursal = '" + d1.id_sucursal
                 + "' Where id_cajero = '" + id + "';";

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
                String sql = "DELETE FROM Cajero"
                         + " WHERE id_cajero=" + id + " ;";
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
