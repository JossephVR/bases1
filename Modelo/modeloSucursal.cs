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
    public class modeloSucursal
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(sucursal d1)
        {
            Conexion conex = new Conexion();
            try
            {
                //nombre, direccion, telefono, id_gerente
                String sql = "INSERT INTO Sucursal("
                        + "nombre, direccion, telefono, id_gerente"
                        + ")"
                        + " VALUES ('" + d1.nombre
                        + "', '" + d1.direccion
                        + "', '" + d1.telefono
                        + "', '" + d1.id_gerente
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

        public List<sucursal> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<sucursal> lista = new List<sucursal>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Sucursal ORDER BY id_sucursal ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    sucursal d1 = new sucursal();
                    {
                        //nombre, direccion, telefono, id_gerente

                        d1.id_sucursal = (int)item["id_sucursal"];
                        d1.nombre = (string)item["nombre"];
                        d1.direccion = (string)item["direccion"];
                        d1.telefono = (string)item["telefono"];
                        d1.id_gerente = (int)item["id_gerente"];

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

        public void Actulizar(sucursal d1, int id)
        {
            Conexion conex = new Conexion();

            try
            { // //nombre, direccion, telefono, id_gerente
                string sql = "update Sucursal Set nombre = '" + d1.nombre
                 + "', direccion = '" + d1.direccion
                 + "', telefono = '" + d1.telefono
                 + "', id_gerente = '" + d1.id_gerente
                 + "' Where id_sucursal = '" + id + "';";

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
                String sql = "DELETE FROM Sucursal"
                         + " WHERE id_sucursal=" + id + " ;";
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
