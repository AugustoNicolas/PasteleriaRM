using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public int nit { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string referencia { get; set; }

        // atributos para ubicacion 
        public double lat { get; set; }
        public double lng { get; set; }
        public string descripcionMap { get; set; }
    }
}
