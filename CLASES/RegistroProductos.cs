using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES
{
    public class RegistroProductos
    {
        private static RegistroProductos _instancia;
        private static readonly object _lock = new object();
        public List<Productos> Inventario { get; private set; }

        private RegistroProductos()
        {
            Inventario = new List<Productos>();
        }

        public static RegistroProductos Instancia
        {
            get
            {
                lock (_lock)
                {
                    if (_instancia == null)
                        _instancia = new RegistroProductos();
                    return _instancia;
                }
            }
        }

       
    }
}
