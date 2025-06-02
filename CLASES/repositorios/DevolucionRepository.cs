using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public class DevolucionRepository : IDevolucionRepository
    {
        private readonly string _connectionString;

        public DevolucionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void RegistrarDevolucion(int ventaId, int productoId, int cantidad)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_RegistrarDevolucion", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VentaID", ventaId);
                cmd.Parameters.AddWithValue("@ProductoID", productoId);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

}
