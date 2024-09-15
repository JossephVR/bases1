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
    public class modeloConsulta5
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public List<consulta5> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<consulta5> lista = new List<consulta5>();
            try
            {
                string sql = "SELECT TOP 5 Articulo.nombre AS Articulo, SUM(Pedido.cantidad_articulo) AS Total_Ventas FROM Articulo INNER JOIN Inventario ON Inventario.id_articulo = Articulo.id_articulo INNER JOIN Pedido ON Pedido.id_articulo = Articulo.id_articulo GROUP BY Articulo.nombre ORDER BY Total_Ventas DESC;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    consulta5 d1 = new consulta5();
                    {
                        d1.Articulo = (string)item["Articulo"];
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
