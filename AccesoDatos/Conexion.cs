using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ErpTEC.AccesoDatos
{
    public class Conexion
    {
        private static String bd = "super";
        private static String login = "test";
        private static String password = "test";
        private static String server = "JOSSEPH\\SQLEXPRESS";
        private static String port = "1433";
        public Conexion()
        {
            try
            {
                Conn =
                    new SqlConnection("Server=" + server + ";User Id=" + login + ";Password=" + password + ";Database=" +
                              bd);
                Conn.Open();
            }
            catch (Exception error)
            {
                ExisteError = true;
                MensajeError = error.Message;

            }
        }

        public static bool ExisteError { get; set; } = false;
        public static string MensajeError { get; set; } = "";
        public SqlConnection Conn { get; set; } = null;

    }
}
