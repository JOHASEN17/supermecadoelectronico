using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using supermecadoelectronico.CLASES.utils;

namespace supermecadoelectronico.CLASES.repositorios
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly SqlConnection _conexion;

        public ProductoRepository()
        {
            _conexion = dbConexionsingleton.Instancia;
        }

        public List<Productos> ObtenerTodos()
        {
            var lista = new List<Productos>();
            var cmd = new SqlCommand("sp_ListarProductos", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            _conexion.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Productos
                {
                    IDProductos = Convert.ToInt32(reader["PRODUCTOID"]),
                    Marca = reader["MARCA"].ToString(),
                    Modelo = reader["MODELO"].ToString(),
                    Precio = Convert.ToDecimal(reader["PRECIO"]),
                    Cantidad = Convert.ToInt32(reader["CANTIDADINVENTARIO"])
                });
            }
            _conexion.Close();
            return lista;
        }

        public void Insertar(Productos producto)
        {
            var cmd = new SqlCommand("sp_InsertarProducto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTOID", producto.IDProductos);
            cmd.Parameters.AddWithValue("@MARCA", producto.Marca);
            cmd.Parameters.AddWithValue("@MODELO", producto.Modelo);
            cmd.Parameters.AddWithValue("@PRECIO", producto.Precio);
            cmd.Parameters.AddWithValue("@CANTIDAD", producto.Cantidad);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Actualizar(Productos producto)
        {
            var cmd = new SqlCommand("sp_ActualizarProducto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTOID", producto.IDProductos);
            cmd.Parameters.AddWithValue("@MARCA", producto.Marca);
            cmd.Parameters.AddWithValue("@MODELO", producto.Modelo);
            cmd.Parameters.AddWithValue("@PRECIO", producto.Precio);
            cmd.Parameters.AddWithValue("@CANTIDAD", producto.Cantidad);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Eliminar(int id)
        {
            var cmd = new SqlCommand("sp_EliminarProducto", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTOID", id);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }
    }
}
