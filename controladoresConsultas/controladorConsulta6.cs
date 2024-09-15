using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.entidadesConsulta;
using WindowsFormsApp2.modelosConsultas;

namespace WindowsFormsApp2.controladoresConsultas
{
    public class controladorConsulta6
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public List<consulta6> Obtener()
        {
            modeloConsulta6 oModeloCliente = new modeloConsulta6();
            List<consulta6> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }
    }
}
