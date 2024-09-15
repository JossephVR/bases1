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
    public class modeloConsulta6
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public List<consulta6> Obtener()
        {
            Conexion conex = new Conexion();
            DataTable resultado = new DataTable();
            List<consulta6> lista = new List<consulta6>();
            try
            {
                string sql = "SELECT Factura.fecha_factura AS Fecha, Factura.hora_factura AS Hora, Factura.precio_total AS Total_Ventas FROM Factura WHERE MONTH(Factura.fecha_factura) = 11 AND YEAR(Factura.fecha_factura) = 2022;";
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(sql, conex.Conn);
                SqlDataAdapter.Fill(resultado);

                foreach (DataRow item in resultado.Rows)
                {
                    consulta6 d1 = new consulta6();
                    {
                        d1.Fecha = (DateTime)item["Fecha"];
                        d1.Hora = (TimeSpan)item["Hora"];
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
