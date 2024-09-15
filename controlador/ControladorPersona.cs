using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Entidades;
using WindowsFormsApp2.Modelo;

//namespace WindowsFormsApp2.controlador

namespace ErpTEC.Controlador
{
    internal class ControladorPersona
    {
        public bool ExisteError { get; set; } = false;
        public string MensajeError { get; set; } = "";

        public void Crear(persona p1)
        {
            modeloPersona oModeloPersona = new modeloPersona();
            oModeloPersona.Crear(p1);
            if (oModeloPersona.ExisteError)
            {
                ExisteError = true;
                MensajeError = oModeloPersona.MensajeError;
            }
        }
    }
}
