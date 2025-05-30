using supermecadoelectronico.CLASES.Carrito_de_compras;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public interface IVentaRepository
    {
        void RegistrarVenta(ItemCarrito item, SqlConnection connection);
    }
}
