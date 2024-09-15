using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.entidadesConsulta;
using WindowsFormsApp2.modelosConsultas;

namespace WindowsFormsApp2.controladoresConsultas
{
    public class controladorConsulta7
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public List<consulta7> Obtener()
        {
            modeloConsulta7 oModeloCliente = new modeloConsulta7();
            List<consulta7> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }
    }
}
