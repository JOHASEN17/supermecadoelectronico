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

        private bool esAdmin;

        public Ventas()
        {
            InitializeComponent();
            CargarProductosGrid();

        }

        private void AplicarPermisos()
        {
            if (!esAdmin)
            {
                // Ocultar o deshabilitar funciones que solo un administrador puede usar
               // btnEliminar.Visible = false;
                //btnActualizar.Visible = false;
                //btnAgregarProveedor.Visible = false;
                //btnproveedor.Visible = false;

                // O deshabilitarlos si prefieres:
                // btnEliminar.Enabled = false;
                // btnActualizar.Enabled = false;

                lblmodo.Text = esAdmin ? "Modo Administrador" : "Modo Empleado";
                lblmodo.ForeColor = esAdmin ? Color.Green : Color.DarkOrange;

            }
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

       

        private void btnvender_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-CG8J6ADN\\SQLEXPRESS;Initial Catalog=SUPERMERCADO;Integrated Security=True; TrustServerCertificate=True";
            IVentasService ventaService = new VentaService(cs);

            try
            {
                if (carrito.Items.Count == 0)
                {
                    MessageBox.Show("El carrito está vacío.");
                    return;
                }

                ventaService.RegistrarVentas(carrito.Items);

                MessageBox.Show("Venta registrada correctamente.");

                carrito.Limpiar();
                dgvcarrito.DataSource = null;

                
                CargarProductosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message);
            }
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

       

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtbuscar.Text, out id))
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-CG8J6ADN\\SQLEXPRESS;Initial Catalog=SUPERMERCADO;Integrated Security=True; TrustServerCertificate=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCTOS WHERE PRODUCTOID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtmarca.Text = reader["Marca"].ToString();
                        txtModelo.Text = reader["Modelo"].ToString();
                        txtPrecio.Text = reader["Precio"].ToString();
                        txtcantidad.Text = reader["cantidadinventario"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }

                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido.");
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefrescarCarrito()
        {
            dgvcarrito.DataSource = null;
            dgvcarrito.DataSource = carrito.Items;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgvcarrito.CurrentRow != null)
            {
                int idProducto = (int)dgvcarrito.CurrentRow.Cells["Productoid"].Value;

                carrito.EliminarItem(idProducto);
                RefrescarCarrito();
            }
            else
            {
                MessageBox.Show("Selecciona un producto del carrito para eliminar.");
            }
        }
    }
}
