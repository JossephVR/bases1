using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.entidadesConsulta;

namespace WindowsFormsApp2.modelosConsultas
{
    public class modeloAgregarPedido
    {
        public bool ExisteError { get; private set; } = false;
        public string MensajeError { get; private set; } = "";

        public void Crear(agregarPedido d1)
        {
            Conexion conex = new Conexion();
            try
            {
                String sql = "generar_pedido "
                        + d1.id_cliente + ", "
                        + d1.id_cajero + ", "
                        + d1.id_articulo + ", "
                        + d1.cantidad_articulo;
                        
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
    }
}
