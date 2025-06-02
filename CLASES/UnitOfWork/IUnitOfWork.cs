using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using supermecadoelectronico.CLASES.services;
using supermecadoelectronico.CLASES.repositorios;

namespace supermecadoelectronico.CLASES.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductoRepository ProductoRepository { get; }

        IProveedorrepository Proveedoresrepository { get; }

        IVentasService VentaService { get; }
        IDevolucionRepository DevolucionRepository { get; }
        IAlertaRepository AlertaRepository { get; }

    }
}
