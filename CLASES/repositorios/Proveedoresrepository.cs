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
            var cmd = new SqlCommand("SP_listarprovedores", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            _conexion.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Proveedores
                {
                    IDProductos = Convert.ToInt32(reader["PRODUCTOID"]),
                    Nombre = reader["NOMBRE"].ToString(),
                    Contacto = reader["CONTACTO"].ToString(),
                    ProveedorID = Convert.ToInt32(reader["IDPROVEEDOR"])
                });
            }
            _conexion.Close();
            return lista;
        }

        public void Insertar(Proveedores proveedores)
        {
            var cmd = new SqlCommand("sp_InsertarProveedor", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", proveedores.Nombre);
            cmd.Parameters.AddWithValue("@CONTACTO", proveedores.Contacto);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Actualizar(Proveedores proveedores)
        {

            var cmd = new SqlCommand("SP_ActualizarProveedores", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NOMBRE", proveedores.Nombre);
            cmd.Parameters.AddWithValue("@CONTACTO", proveedores.Contacto);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

        public void Eliminar(int id)
        {
            var cmd = new SqlCommand("SP_ELIMARPROVEEDOR", _conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PROVEEDORID", id);

            _conexion.Open();
            cmd.ExecuteNonQuery();
            _conexion.Close();
        }

    }
}
