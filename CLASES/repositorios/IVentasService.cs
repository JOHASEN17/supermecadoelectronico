using supermecadoelectronico.CLASES.Carrito_de_compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public interface IVentasService
    {
        void RegistrarVentas(List<ItemCarrito> items);
    }
}
