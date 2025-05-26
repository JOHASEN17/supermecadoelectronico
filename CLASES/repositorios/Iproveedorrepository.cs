using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public interface IProveedorrepository
    {
        List<Proveedores> ObtenerTodos();

        void Insertar(Proveedores proveedores);
        void Actualizar(Proveedores proveedores);
        void Eliminar(int ProveedorID);
    }
}
