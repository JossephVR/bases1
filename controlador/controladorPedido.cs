using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;

namespace WindowsFormsApp2.controlador
{
    public class controladorPedido
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public void Crear(pedido d1)
        {
            modeloPedido oModeloCliente = new modeloPedido();
            oModeloCliente.Crear(d1);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public List<pedido> Obtener()
        {
            modeloPedido oModeloCliente = new modeloPedido();
            List<pedido> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }

        public void Actulizar(pedido d1, int id)
        {
            modeloPedido oModeloCliente = new modeloPedido();
            oModeloCliente.Actulizar(d1, id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public void Eliminar(int id)
        {
            modeloPedido oModeloCliente = new modeloPedido();
            oModeloCliente.Eliminar(id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }
    }
}
