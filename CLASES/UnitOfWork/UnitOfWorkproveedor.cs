using supermecadoelectronico.CLASES.repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.UnitOfWork
{
    public class UnitOfWorkproveedor : UnitOfWork
    {
        public IProveedorrepository proveedoresrepository { get; }

        public UnitOfWorkproveedor()
        {

            proveedoresrepository = new Proveedoresrepository();
        }
    }
}
