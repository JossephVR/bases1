using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.entidadesConsulta;
using WindowsFormsApp2.modelosConsultas;

namespace WindowsFormsApp2.controladoresConsultas
{
    public class controladorConsulta3
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public List<consulta3> Obtener()
        {
            modeloConsulta3 oModeloCliente = new modeloConsulta3();
            List<consulta3> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }
    }
}
