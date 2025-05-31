using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public class AlertaRepository : IAlertaRepository
    {
        private readonly string connectionString;

        public AlertaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void GenerarAlertasInventario(int limite)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_EnviarAlertaInventario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Limite", limite);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Alerta> ObtenerAlertas()
        {
            var alertas = new List<Alerta>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT A.ALERTAID, A.PRODUCTOID, P.MARCA, P.MODELO, A.MENSAJE, A.FECHAALERTA 
                             FROM ALERTAS A 
                             JOIN PRODUCTOS P ON A.PRODUCTOID = P.PRODUCTOID 
                             ORDER BY A.FECHAALERTA DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alertas.Add(new Alerta
                            {
                                AlertaID = reader.GetInt32(0),
                                ProductoID = reader.GetInt32(1),
                                Marca = reader.GetString(2),
                                Modelo = reader.GetString(3),
                                Mensaje = reader.GetString(4),
                                FechaAlerta = reader.GetDateTime(5)
                            });
                        }
                    }
                }
            }

            return alertas;
        }
    }
}
