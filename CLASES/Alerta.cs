using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES
{
    public class Alerta
    {
        public int AlertaID { get; set; }
        public int ProductoID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaAlerta { get; set; }
    }
}
