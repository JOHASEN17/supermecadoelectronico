using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermecadoelectronico.CLASES
{
    public abstract class Productos
    {
        public int IDProductos { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Catidad { get; set; }


        public Productos(int IDproductos, string marca, string modelo, decimal precio, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(marca))
            {
                throw new ArgumentException("la marca no puede estar vacio");
            }
            if (string.IsNullOrWhiteSpace(modelo))
            {
                throw new ArgumentException("el numero base debe ser mayor a 0");
            }
            if (precio <= 0)
            {
                throw new ArgumentException("el nuemro de base debe ser mayor a 0");
            }
            if (cantidad <= 0)
            {
                throw new ArgumentException("el nuemro de base debe ser mayor a 0");
            }

            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Catidad = cantidad;
        }

        public abstract double CalcularCostoTotal();

    }
}
