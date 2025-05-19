using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace supermecadoelectronico.CLASES.repositorios
{
    public sealed class dbConexionsingleton
    {
        private static SqlConnection _conexion;
        private static readonly object _lock = new object();

        private dbConexionsingleton() { }

        public static SqlConnection Instancia
        {
            get
            {
                if (_conexion == null || _conexion.State == System.Data.ConnectionState.Broken)
                {
                    lock (_lock)
                    {
                        if (_conexion == null || _conexion.State == System.Data.ConnectionState.Broken)
                        {
                            string cadena = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                            _conexion = new SqlConnection(cadena);

                        }
                    }
                }
                return _conexion;
            }
        }
    }
}
