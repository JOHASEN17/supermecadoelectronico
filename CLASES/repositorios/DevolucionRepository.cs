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
    public class DevolucionRepository : IDevolucionRepository
    {
        private readonly SqlConnection _connection;

        public DevolucionRepository()
        {
            _connection = dbConexionsingleton.Instancia;
        }

        public void RegistrarDevolucion(Devolucion devolucion)
        {
            var cmd = new SqlCommand("SP_RegistrarDevolucion", _connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VentaID", devolucion.Id);
            cmd.Parameters.AddWithValue("@ProductoID", devolucion.IdProducto);
            cmd.Parameters.AddWithValue("@Cantidad", devolucion.CantidadDevuelta);
            cmd.Parameters.AddWithValue("@Motivo", devolucion.Motivo);

            _connection.Open();
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
