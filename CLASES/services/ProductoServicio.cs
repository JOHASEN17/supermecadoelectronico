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
    public class ProductoServicio
    {
        public List<Productos> ListarProductos()
        {
            var productos = new List<Productos>();

            using (var conn = dbConexionsingleton.Instancia)
            {
                using (var cmd = new SqlCommand("sp_ListarProductos", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Productos
                            {
                                IDProductos = reader.GetInt32(reader.GetOrdinal("PRODUCTOID")),
                                Marca = reader.GetString(reader.GetOrdinal("MARCA")),
                                Modelo = reader.GetString(reader.GetOrdinal("MODELO")),
                                Precio = reader.GetDecimal(reader.GetOrdinal("PRECIO")),
                                Cantidad = reader.GetInt32(reader.GetOrdinal("CANTIDADINVENTARIO"))
                            });
                        }
                    }
                }
            }

            return productos;
        }

    }
}
