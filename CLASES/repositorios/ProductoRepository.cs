using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using supermecadoelectronico.CLASES.utils;

namespace supermecadoelectronico.CLASES
{
    public class ProductoRepository
    {
        private readonly SqlConnection _conexion;

        public ProductoRepository()
        {
            _conexion = dbConexionsingleton.Instancia;
        }

        public List<Productos> ObtenerTodos()
        {
            var lista = new List<Productos>();
            var cmd = new SqlCommand("SELECT * FROM PRODUCTOS", _conexion);

            _conexion.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Productos
                {
                    IDProductos = Convert.ToInt32(reader["IDPRODUCTO"]),
                    Marca = reader["MARCA"].ToString(),
                    Modelo = reader["MODELO"].ToString(),
                    Precio = Convert.ToDecimal(reader["PRECIO"]),
                    Cantidad = Convert.ToInt32(reader["CANTIDAD"])
                });
            }
            _conexion.Close();
            return lista;
        }

        public void Insertar(Productos producto)
        {
            var cmd = new SqlCommand(@"
            INSERT INTO PRODUCTOS (PRODUCTOID, MARCA, MODELO, PRECIO, CANTIDADINVENTARIO)
            VALUES (@ID, @Marca, @Modelo, @Precio, @Cantidad)", _conexion);

            cmd.Parameters.AddWithValue("@ID", producto.IDProductos);
            cmd.Parameters.AddWithValue("@Marca", producto.Marca);
            cmd.Parameters.AddWithValue("@Modelo", producto.Modelo);
            cmd.Parameters.AddWithValue("@Precio", producto.Precio);
            cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Actualizar(Productos producto)
        {
            var cmd = new SqlCommand(@"
            UPDATE PRODUCTOS 
            SET MARCA = @Marca, MODELO = @Modelo, PRECIO = @Precio, CANTIDADINVENTARIO = @Cantidad
            WHERE PRODUCTOID = @ID", _conexion);

            cmd.Parameters.AddWithValue("@ID", producto.IDProductos);
            cmd.Parameters.AddWithValue("@Marca", producto.Marca);
            cmd.Parameters.AddWithValue("@Modelo", producto.Modelo);
            cmd.Parameters.AddWithValue("@Precio", producto.Precio);
            cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Eliminar(int id)
        {
            var cmd = new SqlCommand("DELETE FROM PRODUCTOS WHERE PRODUCTOID = @ID", _conexion);
            cmd.Parameters.AddWithValue("@ID", id);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }
    }
}
