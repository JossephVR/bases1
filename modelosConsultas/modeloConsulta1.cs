using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.entidadesConsulta;

namespace WindowsFormsApp2.modelosConsultas
{
    public class modeloConsulta1
    {

        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public List<consulta1> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<consulta1> lista = new List<consulta1>();
            try
            {
                string sql = "SELECT Articulo.nombre, SUM(Pedido.cantidad_articulo) AS Cantidad_Vendida FROM Articulo INNER JOIN Pedido ON Articulo.id_articulo = Pedido.id_articulo WHERE Articulo.id_articulo = 1 GROUP BY Articulo.nombre;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    consulta1 d1 = new consulta1();
                    {
                        d1.nombre= (string)item["nombre"];
                        d1.cantidad_vendida = (int)item["Cantidad_Vendida"];
                        ;

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
