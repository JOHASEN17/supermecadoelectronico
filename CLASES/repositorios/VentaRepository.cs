using supermecadoelectronico.CLASES.Carrito_de_compras;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public class VentaRepository : IVentaRepository
    {
        public void RegistrarVenta(ItemCarrito item, SqlConnection connection)
        {
            using (var cmd = new SqlCommand("SP_RegistrarVenta", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", item.ProductoId);
                cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioVenta", item.PrecioUnitario);
                cmd.Parameters.AddWithValue("@Fecha", DateTime.Now.Date);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
