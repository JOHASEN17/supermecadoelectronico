﻿using supermecadoelectronico.CLASES;
using supermecadoelectronico.CLASES.Carrito_de_compras;
using supermecadoelectronico.CLASES.repositorios;
using supermecadoelectronico.CLASES.services;
using supermecadoelectronico.CLASES.UnitOfWork;
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
        private readonly IUnitOfWork _uow = new UnitOfWork();
        private readonly ProductoServicio productoService = new ProductoServicio();
        private Carrito carrito = new Carrito();

        private bool esAdmin;
        public Ventas(bool esAdmin)
        {
            InitializeComponent();
            CargarProductosGrid();
            this.esAdmin = esAdmin;
            AplicarPermisos();
          
        }

       private void AplicarPermisos()
        {
            if (!esAdmin)
            {

                btndevoluciones.Visible = false;
                btnpedidos.Visible = false;
                btnprovedor.Visible = false;
                lblmd.Text = "Modo Empleado";
                lblmd.ForeColor = Color.Green;

            }
            else
            {
                lblmd.Text = "Modo Administrador";
                lblmd.ForeColor = Color.Green;
            }
        }

        private void CargarProductosGrid()
        {
            try
            {
                dtgProductos.DataSource = _uow.ProductoRepository.ObtenerTodos();
                dtgProductos.ClearSelection();
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

                _uow.VentaService.RegistrarVentas(carrito.Items);

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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("agregar un producto a al carrito" + ex.Message);
            }
        }



        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar producto: " + ex.Message);
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
            try { 
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar del carrito: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Devoluciones Ventas = new Devoluciones();
            Ventas.Show();
        }

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            Form1 Ventas = new Form1();
            Ventas.Show();
        }

        private void btnprovedor_Click(object sender, EventArgs e)
        {
            Proveedor Ventas = new Proveedor();
            Ventas.Show();
        }
    }
}
