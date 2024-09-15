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
    public class modeloProveedor
    {

        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(proveedor p1)
        {
            Conexion conex = new Conexion();
            try
            {
                String sql = "INSERT INTO Proveedor("
                        + "nombre_proveedor, contacto, tipo_proveedor"
                        + ")"
                        + " VALUES ('" + p1.nombre_proveedor
                        + "', '" + p1.contacto 
                        + "', '" + p1.tipo_proveedor
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

        public List<proveedor> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<proveedor> lista = new List<proveedor>();
            try
            {
                //EXEC ObtenerSaldoCuenta 1 'A2';
                string sql = "SELECT * FROM Proveedor ORDER BY id_prov ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    proveedor d1 = new proveedor();
                    {
                        d1.id_prov = (int)item["id_prov"];
                        d1.nombre_proveedor = (string)item["nombre_proveedor"];
                        d1.contacto = (string)item["contacto"];
                        d1.tipo_proveedor = (string)item["tipo_proveedor"];

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

        public void Actulizar(proveedor d1, int id)
        {
            Conexion conex = new Conexion();

            try
            {
                string sql = "update Proveedor Set nombre_proveedor = '" + d1.nombre_proveedor
                 + "', contacto = '" + d1.contacto
                 + "', tipo_proveedor = '" + d1.tipo_proveedor
                 + "' Where id_prov = '" + id + "';";

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
                String sql = "DELETE FROM Proveedor"
                         + " WHERE id_prov=" + id + " ;";
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
