using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallePedido
    {
        public int idDetallePedido { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
    }
}
