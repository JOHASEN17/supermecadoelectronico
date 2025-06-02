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
        private readonly string _connectionString;
        public IProductoRepository ProductoRepository { get; }
        public IProveedorrepository Proveedoresrepository { get; }
        public IVentasService VentasService { get; }
        public IDevolucionRepository DevolucionRepository { get; }
        public IAlertaRepository AlertaRepository { get; }

        public UnitOfWork()
        {
            _connectionString = "Data Source=LAPTOP-CG8J6ADN\\SQLEXPRESS;Initial Catalog=SUPERMERCADO;Integrated Security=True;TrustServerCertificate=True";

            ProductoRepository = new ProductoRepository();
            Proveedoresrepository = new Proveedoresrepository(_connectionString);
            VentasService = new VentaService(_connectionString);
            DevolucionRepository = new DevolucionRepository(_connectionString);
            AlertaRepository = new AlertaRepository(_connectionString);


        }
    }
}
