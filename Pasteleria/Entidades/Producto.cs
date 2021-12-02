using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public string categoria { get; set; }
        public string tamaño { get; set; }
        public int produccion { get; set; }
        public string cantidad { get; set; }
        public byte[] foto { get; set; }
    }
}
