using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Trabajador
    {
        public int idTrabajador { get; set; }
        public int ciTrabajador { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string nick { get; set; }
        public int estado { get; set; }
        public DateTime dateIn { get; set; }
        public DateTime dateMod { get; set; }
    }
}
