using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public interface IProveedorrepository
    {
        List<Proveedor> ObtenerTodos();

        void Insertar(Proveedor proveedor);
        void Actualizar(Proveedor proveedor);
        void Eliminar(int ProveedorID);
    }
}
