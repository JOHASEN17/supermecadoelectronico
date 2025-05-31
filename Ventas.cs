using supermecadoelectronico.CLASES;
using supermecadoelectronico.CLASES.Carrito_de_compras;
using supermecadoelectronico.CLASES.repositorios;
using supermecadoelectronico.CLASES.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermecadoelectronico
{
    public partial class Ventas : Form
    {
        private readonly ProductoServicio productoService = new ProductoServicio();
        private Carrito carrito = new Carrito();
        public Ventas()
        {
            InitializeComponent();
            CargarProductosGrid();
        }
        private void CargarProductosGrid()
        {
            try
            {
                var productos = productoService.ListarProductos();
                dtgProductos.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (cmbProductos.SelectedItem is Productos producto)
            {
                txtPrecio.Text = producto.Precio.ToString("C");
                txtcantidad.Text = producto.Cantidad.ToString();
            }
           */
        }

        private void btnvender_Click(object sender, EventArgs e)
        {/*
            try
            {
                foreach (var item in carrito.Items)
                {
                    VentaServicio.RegistrarVenta(
                        item.ProductoID,
                        item.Cantidad,
                        item.PrecioUnitario
                    );
                }

                MessageBox.Show("Venta registrada con éxito.");
                carrito.Limpiar();
                dgvcarrito.DataSource = null;
                CargarProductosGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
            */
        }

        private void ActualizarVistaCarrito()
        {
            dgvcarrito.DataSource = null;
            dgvcarrito.DataSource = carrito.Items;
            lblTotal.Text = $"Total: {carrito.CalcularTotal():C}";
        }

        private void btnagrrgaralcarrito_Click(object sender, EventArgs e)
        {
            decimal precio = decimal.Parse(txtPrecio.Text);

            if (dtgProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            string modelo = dtgProductos.CurrentRow.Cells["Modelo"].Value?.ToString().Trim();
            string marca = dtgProductos.CurrentRow.Cells["Marca"].Value?.ToString().Trim();


            if (!int.TryParse(txtcantidad.Text, out int cantidad))
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            if (!int.TryParse(txtbuscar.Text, out int productoid))
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }


            carrito.AgregarItem(modelo, marca, cantidad, precio, productoid);
            ActualizarVistaCarrito();
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {/*
            VentaServicio.RegistrarVenta(carrito.Items.ToList());
            MessageBox.Show("Venta registrada con éxito");
            carrito.Limpiar();
            dgvcarrito.DataSource = null;
            lblTotal.Text = "Total: $0.00";
            */
        }
    }
}
