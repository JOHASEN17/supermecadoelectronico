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
    public class Proveedoresrepository : IProveedorrepository
    {
        private readonly SqlConnection _conexion;

        public Proveedoresrepository()
        {
            _conexion = dbConexionsingleton.Instancia;
        }

        public List<Proveedores> ObtenerTodos()
        {
            var lista = new List<Proveedores>();
            var cmd = new SqlCommand("sp", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            _conexion.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Proveedores
                {
                    IDProductos = Convert.ToInt32(reader["PRODUCTOID"]),
                    Proveedor = reader["PROVEEDOR"].ToString(),
                    Contacto = reader["CONTACTO"].ToString(),
                    ProveedorID = Convert.ToInt32(reader["IDPROVEEDOR"])
                });
            }
            _conexion.Close();
            return lista;
        }

        public void Insertar(Proveedor proveedor)
        {
            var cmd = new SqlCommand("sp_InsertarProveedor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor.proveedor);
            cmd.Parameters.AddWithValue("@CONTACTO", proveedor.Contacto);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Actualizar(Proveedor proveedor)
        {

            var cmd = new SqlCommand("sp_ActualizarProveedor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PROVEEDOR", proveedor.proveedor);
            cmd.Parameters.AddWithValue("@CONTACTO", proveedor.Contacto);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Eliminar(int id)
        {
            var cmd = new SqlCommand("sp_EliminarProveedor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PROVEEDORID", id);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

    }
}
