using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.entidadesConsulta;
using WindowsFormsApp2.modelosConsultas;

namespace WindowsFormsApp2.controladoresConsultas
{
    public class controladorConsulta8
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public List<consulta8> Obtener()
        {
            modeloConsulta8 oModeloCliente = new modeloConsulta8();
            List<consulta8> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }
    }
}
