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
    public class modeloConsulta8
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public List<consulta8> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<consulta8> lista = new List<consulta8>();
            try
            {
                string sql = "SELECT Proveedor.nombre_proveedor AS Proveedor, COUNT(*) AS Total_Articulos FROM Proveedor INNER JOIN Articulo ON Articulo.id_proveedor = Proveedor.id_prov GROUP BY Proveedor.nombre_proveedor;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    consulta8 d1 = new consulta8();
                    {
                        d1.Proveedor = (string)item["Proveedor"];
                        d1.Total_Articulo = (int)item["Total_Articulos"];


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
