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
    public class modeloConsulta7
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public List<consulta7> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<consulta7> lista = new List<consulta7>();
            try
            {
                string sql = "SELECT TOP 3 Articulo.nombre AS Articulo, SUM(Pedido.cantidad_articulo) AS Total_Ventas, SUM(Pedido.cantidad_articulo * Articulo.precio) AS Total_Ganancias FROM Articulo INNER JOIN Inventario ON Inventario.id_articulo = Articulo.id_articulo INNER JOIN Pedido ON Pedido.id_articulo = Articulo.id_articulo GROUP BY Articulo.nombre ORDER BY Total_Ventas ASC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    consulta7 d1 = new consulta7();
                    {
                        d1.Articulo = (string)item["Articulo"];
                        d1.Total_Ventas = (int)item["Total_Ventas"];
                        d1.Total_Ganancias = (int)item["Total_Ganancias"];


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
