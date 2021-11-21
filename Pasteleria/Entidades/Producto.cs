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
        public float precio { get; set; }
        public int stock { get; set; }
        public string categoria { get; set; }
        public string tamaño { get; set; }
        public string saborMasa { get; set; }
        public string saborRelleno { get; set; }
        public string relleno { get; set; }
    }
}
