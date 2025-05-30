using supermecadoelectronico.CLASES.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.services
{
    public class ProductoService
    {
        public List<Productos> ListarProductos()
        {
            List<Productos> productos = new List<Productos>();

            using (SqlConnection conn = dbConexionsingleton.Instancia)
            {
                SqlCommand cmd = new SqlCommand("sp_ListarProductos", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new Productos
                        {
                            IDProductos = Convert.ToInt32(reader["PRODUCTOID"]),
                            Marca = reader["MARCA"].ToString(),
                            Modelo = reader["MODELO"].ToString(),
                            Precio = Convert.ToDecimal(reader["PRECIO"]),
                            Cantidad = Convert.ToInt32(reader["CANTIDADINVENTARIO"])
                        });
                    }
                }
            }

            return productos;
        }
    }
}
