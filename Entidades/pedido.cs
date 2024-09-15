using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Entidades
{
    public class pedido //fecha_pedido, hora_pedido, id_cliente,
                        //id_cajero, id_articulo, cantidad_articulo
    {
        public int id_pedido;
        public DateTime fecha_pedido;
        public TimeSpan hora_pedido;
        public int id_cliente;
        public int id_cajero;
        public int id_articulo;
        public int catidad_articulo;
    }
}
