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
    public class VentaService : IVentasService
    {
        private readonly string _connectionString = "Data Source=LAPTOP-CG8J6ADN\\SQLEXPRESS;Initial Catalog=SUPERMERCADO;Integrated Security=True; TrustServerCertificate=True"; 


        public VentaService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Venta> ObtenerTodos()
        {
            var lista = new List<Venta>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("sp_ListarVentas", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Venta
                    {
                        Id = Convert.ToInt32(reader["VENTAID"]),
                        IdProducto = Convert.ToInt32(reader["PRODUCTOID"]), 
                        PrecioUnitario = Convert.ToDecimal(reader["PRECIODEVENTA"]),
                        FechaVenta = Convert.ToDateTime(reader["FECHADEVENTA"]),
                        Cantidad = Convert.ToInt32(reader["CANTIDAD"])
                    });
                }

                connection.Close(); 
            }

            return lista;
        }


        public void RegistrarVenta(ItemCarrito item)
        {
            using (var conn = new SqlConnection(_connectionString))
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

