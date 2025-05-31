using supermecadoelectronico.CLASES.Carrito_de_compras;
using supermecadoelectronico.CLASES.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public class VentaService
    {
        public void RegistrarVenta(ItemCarrito item)
        {
            using (var conn = dbConexionsingleton.Instancia)
            {
                using (var cmd = new SqlCommand("SP_RegistrarVenta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductoID", item.ProductoID);
                    cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioVenta", item.PrecioUnitario);

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }


        }
    

        public void RegistrarVentas(List<ItemCarrito> items)
        {
            foreach (var item in items)
            {
                RegistrarVenta(item);
            }
        }
    }
}

