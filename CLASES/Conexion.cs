using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace supermecadoelectronico.CLASES
{
    class Conexion
    {
        SqlConnection sqlcon;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public void OPen()
        {
            string nombre_servidor = Dns.GetHostName();
            sqlcon = new SqlConnection("Data Source=" + nombre_servidor + ";Initial Catalog=SupermercadoElectronico;Integrated Security=True");
        }


    }
}
