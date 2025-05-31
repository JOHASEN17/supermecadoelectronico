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
    public class VentaServicio
    {
        public void RegistrarVenta(int productoId, int cantidad, decimal precio)
        {
            using (var conn = dbConexionsingleton.Instancia)
            using (var cmd = new SqlCommand("SP_RegistrarVenta", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", productoId);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@PrecioVenta", precio);

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                cmd.ExecuteNonQuery();
            }
        }
    }
}
