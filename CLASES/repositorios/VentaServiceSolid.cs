using supermecadoelectronico.CLASES.Carrito_de_compras;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES.repositorios
{
    public class VentaServiceSolid : IVentasService
    {
        private readonly string _conexion;
        private readonly IVentaRepository _ventaRepository;

        public VentaServiceSolid(string connectionString, IVentaRepository ventaRepository)
        {
            _conexion = connectionString;
            _ventaRepository = ventaRepository;
        }

        public void RegistrarVentas(List<ItemCarrito> items)
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("El carrito está vacío.");

            using (var conn = new SqlConnection(_conexion))
            {
                conn.Open();

                foreach (var item in items)
                {
                    _ventaRepository.RegistrarVenta(item, conn);
                }
            }
        }
    }
}
