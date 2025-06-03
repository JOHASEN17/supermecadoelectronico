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
        private readonly string _cadenaConexion;

        public Proveedoresrepository(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        public List<Proveedores> ObtenerTodos()
        {
            var lista = new List<Proveedores>();

            using (var conn = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand("SP_listarprovedores", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Proveedores
                        {
                            IDProductos = Convert.ToInt32(reader["PRODUCTOID"]),
                            Nombre = reader["NOMBRE"].ToString(),
                            Contacto = reader["CONTACTO"].ToString(),
                            ProveedorID = Convert.ToInt32(reader["PROVEDORID"])
                        });
                    }
                }
            }

            return lista;
        }

        public void Insertar(Proveedores proveedores)
        {
            using (var conn = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand("sp_InsertarProveedor", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRE", proveedores.Nombre);
                cmd.Parameters.AddWithValue("@CONTACTO", proveedores.Contacto);
               

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Proveedores proveedores)
        {
            using (var conn = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand("SP_ActualizarProveedores", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRE", proveedores.Nombre);
                cmd.Parameters.AddWithValue("@CONTACTO", proveedores.Contacto);
               

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var conn = new SqlConnection(_cadenaConexion))
            using (var cmd = new SqlCommand("SP_ELIMINARPROVEEDOR", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PROVEDORID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
