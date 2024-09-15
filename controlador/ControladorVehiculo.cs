using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;

namespace WindowsFormsApp2.controlador
{
    public class ControladorVehiculo
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public void Crear(vehiculo v1)
        {
            modeloVehiculo oModeloVehiculo = new modeloVehiculo();
            oModeloVehiculo.Crear(v1);
            if (oModeloVehiculo.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloVehiculo.MensajeError;
            }
        }

        public List<vehiculo> Obtener()
        {
            modeloVehiculo oModelovehiculo = new modeloVehiculo();
            List<vehiculo> listaVehiculo = oModelovehiculo.Obtener();
            if (oModelovehiculo.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModelovehiculo.MensajeError;
            }
            return listaVehiculo;
        }
    }
}
