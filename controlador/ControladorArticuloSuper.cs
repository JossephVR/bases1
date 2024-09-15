using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;

namespace WindowsFormsApp2.controlador
{
    public class ControladorArticuloSuper
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public void Crear(articuloSuper c1)
        {
            modeloArticuloSuper oModeloCliente = new modeloArticuloSuper();
            oModeloCliente.Crear(c1);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public List<articuloSuper> Obtener()
        {
            modeloArticuloSuper oModeloCliente = new modeloArticuloSuper();
            List<articuloSuper> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }

        public void Actulizar(articuloSuper c1, int id)
        {
            modeloArticuloSuper oModeloCliente = new modeloArticuloSuper();
            oModeloCliente.Actulizar(c1, id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public void Eliminar(int id)
        {
            modeloArticuloSuper oModeloCliente = new modeloArticuloSuper();
            oModeloCliente.Eliminar(id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }
    }
}
