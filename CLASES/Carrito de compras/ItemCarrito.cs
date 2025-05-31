using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.Carrito_de_compras
{
    public class ItemCarrito
    {
        public string Modelo { get; set; }

        public string Marca { get; set; }
        public int ProductoID { get; set; } 
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal Total => Cantidad * (PrecioUnitario);
    }
}
    