using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;

namespace ErpTEC.Controlador
{
    public class ControladorCliente
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public void Crear(Articulo articulo)
        {
            ModeloCliente oModeloCliente = new ModeloCliente();
            oModeloCliente.Crear(articulo);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        

        public List<Articulo> Obtener()
        {
            ModeloCliente oModeloCliente = new ModeloCliente();
            List<Articulo> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }

        /*

        public void Actulizar(Cliente cliente)
        {
            ModeloCliente oModeloCliente = new ModeloCliente();
            oModeloCliente.Actulizar(cliente);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public void Eliminar(Cliente cliente)
        {
            ModeloCliente oModeloCliente = new ModeloCliente();
            oModeloCliente.Eliminar(cliente);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }
        */
        
    }
}
