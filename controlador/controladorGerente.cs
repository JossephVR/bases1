using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;

namespace WindowsFormsApp2.controlador
{
    public class controladorGerente
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public void Crear(gerente c1)
        {
            modeloGerente oModeloCliente = new modeloGerente();
            oModeloCliente.Crear(c1);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public List<gerente> Obtener()
        {
            modeloGerente oModeloCliente = new modeloGerente();
            List<gerente> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }

        public void Actulizar(gerente c1, int id)
        {
            modeloGerente oModeloCliente = new modeloGerente();
            oModeloCliente.Actulizar(c1, id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public void Eliminar(int id)
        {
            modeloGerente oModeloCliente = new modeloGerente();
            oModeloCliente.Eliminar(id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }
    }
}
