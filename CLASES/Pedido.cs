using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES
{
    public class Pedido
    {
        public int IDProductos { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Catidad { get; set; }


        public Pedido(int IDproductos,string marca, string modelo, decimal precio, int cantidad)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Catidad = cantidad;
        }

    }
}
