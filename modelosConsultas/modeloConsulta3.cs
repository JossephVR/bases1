using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.entidadesConsulta;

namespace WindowsFormsApp2.modelosConsultas
{
    public class modeloConsulta3
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public List<consulta3> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<consulta3> lista = new List<consulta3>();
            try
            {
                string sql = "SELECT Cajero.nombre AS Cajero, SUM(Factura.precio_total) AS Total_Ventas FROM Cajero INNER JOIN Pedido ON Pedido.id_cajero = Cajero.id_cajero INNER JOIN Factura ON Factura.id_pedido = Pedido.id_pedido GROUP BY Cajero.nombre;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    consulta3 d1 = new consulta3();
                    {
                        d1.Cajero = (string)item["Cajero"];
                        d1.Total_Ventas = (int)item["Total_Ventas"];


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
    }
}
