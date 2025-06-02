using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico
{
    public class Devolucion
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int CantidadDevuelta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Motivo { get; set; }
    }

}
