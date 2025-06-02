using supermecadoelectronico.CLASES.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.services
{
    public class DevolucionService
    {
        private readonly IDevolucionRepository _repo;

        public DevolucionService(IDevolucionRepository repo)
        {
            _repo = repo;
        }

        public void RegistrarDevolucion(int ventaId, int productoId, int cantidad)
        {
            _repo.RegistrarDevolucion(ventaId, productoId, cantidad);
        }
    }
}
