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
            List<Productos> lista = new List<Productos>();
            SqlCommand cmd = new SqlCommand("sp_ListarProductos", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            _conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Productos
                {
                    IDProductos = Convert.ToInt32(dr["IDProductos"]),
                    Marca = dr["Marca"].ToString(),
                    Modelo = dr["Modelo"].ToString(),
                    Precio = Convert.ToDecimal(dr["Precio"]),
                    Catidad = Convert.ToInt32(dr["Catidad"])
                });
            }
            _conexion.Close();
            return lista;
        }

        public void Insertar(Productos producto)
        {
            SqlCommand cmd = new SqlCommand("SP_RegistrarMovimiento", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", producto.Marca);
            cmd.Parameters.AddWithValue("@Nombre", producto.Modelo);
            cmd.Parameters.AddWithValue("@Precio", producto.Precio);
            cmd.Parameters.AddWithValue("@Stock", producto.Catidad);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

    }
}
