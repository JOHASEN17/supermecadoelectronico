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
    public class VentaService : IVentasService
    {
        private readonly string _conexion;

        public VentaService(string connectionString)
        {
            this._conexion = connectionString;
        }

        public void RegistrarVentas(List<ItemCarrito> items)
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("El carrito está vacío.");

            using (var conn = new SqlConnection(_conexion))
            {
                conn.Open();

                foreach (var item in items)
                {
                    var cmd = new SqlCommand("SP_RegistrarVenta", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Asegúrate de que NombreProducto tenga asociado un ID (puedes extender ItemCarrito)
                    // Aquí asumimos que has extendido ItemCarrito con ProductoID
                    //cmd.Parameters.AddWithValue("@ProductoID", item.ProductoID);
                    cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioVenta", item.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now.Date);

                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
