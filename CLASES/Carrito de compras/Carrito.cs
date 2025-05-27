using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace supermecadoelectronico.CLASES.Carrito_de_compras
{
    public class Carrito
    {
        public List<ItemCarrito> Items { get; } = new List<ItemCarrito>();

        public void AgregarItem(string nombre, int cantidad, decimal precio)
        {
            var existente = Items.FirstOrDefault(i => i.NombreProducto == nombre);
            if (existente != null)
            {
                existente.Cantidad += cantidad;
            }
            else
            {
                Items.Add(new ItemCarrito
                {
                    NombreProducto = nombre,
                    Cantidad = cantidad,
                    PrecioUnitario = precio
                });
            }
        }

        public void EliminarItem(string nombre)
        {
            Items.RemoveAll(i => i.NombreProducto == nombre);
        }

        public decimal CalcularTotal()
        {
            return Items.Sum(i => i.Total);
        }

        public void Limpiar()
        {
            Items.Clear();
        }
    }
}
