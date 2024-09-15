using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.entidadesConsulta;
using WindowsFormsApp2.Modelo;
using WindowsFormsApp2.modelosConsultas;

namespace WindowsFormsApp2.controladoresConsultas

{
    public class controladorConsulta1
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public List<consulta1> Obtener()
        {
            modeloConsulta1 oModeloCliente = new modeloConsulta1();
            List<consulta1> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }


    }

}
