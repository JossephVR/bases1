using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ErpTEC.AccesoDatos;
using WindowsFormsApp2.Entidades;
using System.Data.SqlClient;

namespace WindowsFormsApp2.Modelo
{

        public class modeloPersona
        {
            public bool ExisteError { get; private set; } = false;
            public string MensajeError { get; private set; } = "";

            public void Crear(persona p1)
            {
                Conexion conex = new Conexion();
                try
                {
                    String sql = "INSERT INTO persona("
                            + "id" + ")"
                            + " VALUES ('" + p1.id + "');";
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

