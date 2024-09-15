using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;

namespace WindowsFormsApp2.controlador
{
    public class controladorInventario
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public void Crear(Inventario c1)
        {
            modeloInventario oModeloCliente = new modeloInventario();
            oModeloCliente.Crear(c1);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public List<Inventario> Obtener()
        {
            modeloInventario oModeloCliente = new modeloInventario();
            List<Inventario> listaCliente = oModeloCliente.Obtener();
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
            return listaCliente;
        }

        public void Actulizar(Inventario c1, int id)
        {
            modeloInventario oModeloCliente = new modeloInventario();
            oModeloCliente.Actulizar(c1, id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }

        public void Eliminar(int id)
        {
            modeloInventario oModeloCliente = new modeloInventario();
            oModeloCliente.Eliminar(id);
            if (oModeloCliente.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloCliente.MensajeError;
            }
        }
    }
}
