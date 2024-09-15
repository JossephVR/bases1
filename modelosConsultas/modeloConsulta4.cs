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
    public class modeloConsulta4
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public List<consulta4> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<consulta4> lista = new List<consulta4>();
            try
            {
                string sql = "SELECT TOP 5 Cliente.nombre AS Cliente, SUM(Factura.precio_total) AS Total_Ventas FROM Cliente INNER JOIN Pedido ON Pedido.id_cliente = Cliente.id_cliente INNER JOIN Factura ON Factura.id_pedido = Pedido.id_pedido GROUP BY Cliente.nombre ORDER BY Total_Ventas DESC";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    consulta4 d1 = new consulta4();
                    {
                        d1.Cliente = (string)item["Cliente"];
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
