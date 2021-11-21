using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public int status { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaEntrega { get; set; }
        public float costo { get; set; }
        public string direccionEntrega { get; set; }
        public int numPedido { get; set; }
        public List<Producto> listaDeProductos { get; set; }

    }
}
