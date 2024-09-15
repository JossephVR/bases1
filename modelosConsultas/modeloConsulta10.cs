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
    public class modeloConsulta10
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public List<consulta10> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<consulta10> lista = new List<consulta10>();
            try
            {
                string sql = "SELECT Articulo.nombre AS Articulo, Inventario.cantidad AS Cantidad FROM Articulo INNER JOIN Inventario ON Inventario.id_articulo = Articulo.id_articulo WHERE Inventario.cantidad = (SELECT MIN(Inventario.cantidad) FROM Inventario);";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    consulta10 d1 = new consulta10();
                    {
                        d1.Articulo = (string)item["Articulo"];
                        d1.Cantidad = (int)item["Cantidad"];


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
