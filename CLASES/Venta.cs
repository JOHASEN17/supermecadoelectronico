using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermecadoelectronico.CLASES.services;
using supermecadoelectronico.CLASES.repositorios;

namespace supermecadoelectronico.CLASES
{
    public class Venta
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public DateTime FechaVenta { get; set; }

    }
}
