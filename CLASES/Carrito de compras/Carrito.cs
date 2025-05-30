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

        public void AgregarItem(string modelo, string marca, int cantidad, decimal precio, int productoid)
        {
            var existente = Items.FirstOrDefault(i => i.ProductoID == productoid);
            if (existente != null)
            {
                existente.Cantidad += cantidad;
            }
            else
            {
                Items.Add(new ItemCarrito
                {
                    
                    ProductoID = productoid,
                    Modelo = modelo,
                    Marca = marca,
                    Cantidad = cantidad,
                    PrecioUnitario = precio
                });
            }
        }

        public void EliminarItem(int productoid)
        {
            Items.RemoveAll(i => i.ProductoID == productoid);
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
