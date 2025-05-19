using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES
{
    public interface IProductoRepository
    {
        List<Productos> ObtenerTodos();

        void Insertar(Productos producto);
        void Actualizar(Productos producto);
        void Eliminar(int idProducto);
    }
}
