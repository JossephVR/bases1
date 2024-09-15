using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;

namespace WindowsFormsApp2.controlador
{
    public class controladorCajero
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public void Crear(cajero d1)
        {
            modeloCajero oModeloCliente = new modeloCajero();
            oModeloCliente.Crear(d1);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public List<cajero> Obtener()
        {
            modeloCajero oModeloCliente = new modeloCajero();
            List<cajero> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }

        public void Actulizar(cajero d1, int id)
        {
            modeloCajero oModeloCliente = new modeloCajero();
            oModeloCliente.Actulizar(d1, id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public void Eliminar(int id)
        {
            modeloCajero oModeloCliente = new modeloCajero();
            oModeloCliente.Eliminar(id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }
    }
}
