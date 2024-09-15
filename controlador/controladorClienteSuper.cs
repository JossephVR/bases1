using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;

namespace WindowsFormsApp2.controlador
{
    internal class controladorClienteSuper
    {

        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public void Crear(cliente c1)
        {
            modeloClienteSuper oModeloCliente = new modeloClienteSuper();
            oModeloCliente.Crear(c1);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public List<cliente> Obtener()
        {
            modeloClienteSuper oModeloCliente = new modeloClienteSuper();
            List<cliente> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }

        public void Actulizar(cliente c1, int id)
        {
            modeloClienteSuper oModeloCliente = new modeloClienteSuper();
            oModeloCliente.Actulizar(c1, id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public void Eliminar(int id)
        {
            modeloClienteSuper oModeloCliente = new modeloClienteSuper();
            oModeloCliente.Eliminar(id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }
    }
}
