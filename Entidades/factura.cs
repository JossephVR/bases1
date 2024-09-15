using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Entidades
{
    public class factura
    {
        public int id_factura;
        public DateTime fecha_factura;
        public TimeSpan hora_factura;
        public int id_pedido;
        public int id_cliente;
        public int precio_total;

    }
}
