using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermecadoelectronico.CLASES.services;
using supermecadoelectronico.CLASES.utils;
using supermecadoelectronico.CLASES.repositorios;

namespace supermecadoelectronico.CLASES.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductoRepository ProductoRepository { get; }

        public UnitOfWork()
        {

            ProductoRepository = new ProductoRepository();
        }
    }
}
