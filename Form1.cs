using supermecadoelectronico.CLASES;
using supermecadoelectronico.CLASES.Carrito_de_compras;
using supermecadoelectronico.CLASES.repositorios;
using supermecadoelectronico.CLASES.services;
using supermecadoelectronico.CLASES.UnitOfWork;
using supermecadoelectronico.CLASES.utils;
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
    public partial class Form1 : Form
    {
        private readonly IUnitOfWork _uow = new UnitOfWork(); // Aquí usamos Unit of Work
        private int? productoSeleccionadoId = null;
        private Carrito carrito = new Carrito();

        private bool esAdmin;

        public Form1(bool esAdmin)
        {
            InitializeComponent();
            this.esAdmin = esAdmin;

            AplicarPermisos();
        }

      

        private void CargarProductos()
        {
            dtgProductos.DataSource = _uow.ProductoRepository.ObtenerTodos();
            dtgProductos.ClearSelection();
        }

        private void AplicarPermisos()
        {
            if (!esAdmin)
            {
                // Ocultar o deshabilitar funciones que solo un administrador puede usar
                btnEliminar.Visible = false;
                btnActualizar.Visible = false;
                btnAgregarProveedor.Visible = false;
                btnproveedor.Visible = false;

                // O deshabilitarlos si prefieres:
                // btnEliminar.Enabled = false;
                // btnActualizar.Enabled = false;

                lblModo.Text = esAdmin ? "Modo Administrador" : "Modo Empleado";
                lblModo.ForeColor = esAdmin ? Color.Green : Color.DarkOrange;

            }
        }
        private void LimpiarCampos()
        {
            txtmarca.Clear();
            txtPrecio.Clear();
            txtcantidad.Clear();
            txtModelo.Clear();
            productoSeleccionadoId = null;
            dtgProductos.ClearSelection();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtmarca.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtcantidad.Text) || string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return false;
            }
            if (!decimal.TryParse(txtPrecio.Text, out _) || !int.TryParse(txtcantidad.Text, out _))
            {
                MessageBox.Show("El precio y el stock deben ser números válidos.");
                return false;
            }
            return true;
        }


        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var producto = new Productos
                {
                    Marca = txtmarca.Text,
                    Modelo = txtModelo.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Cantidad = int.Parse(txtcantidad.Text)
                };

                _uow.ProductoRepository.Insertar(producto);
                CargarProductos();
                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (productoSeleccionadoId.HasValue && ValidarCampos())
            {
                var producto = new Productos
                {
                    IDProductos = productoSeleccionadoId.Value,
                    Marca = txtmarca.Text,
                    Modelo = txtModelo.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Cantidad = int.Parse(txtcantidad.Text)
                };

                _uow.ProductoRepository.Actualizar(producto);
                CargarProductos();
                LimpiarCampos();


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbuscar.Text, out int productoId))
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _uow.ProductoRepository.Eliminar(productoId);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido en el campo de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dtgProductos.Rows[e.RowIndex];
                productoSeleccionadoId = Convert.ToInt32(fila.Cells["IdProductos"].Value);
                txtmarca.Text = fila.Cells["Marca"].Value.ToString();
                txtModelo.Text = fila.Cells["modelo"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtcantidad.Text = fila.Cells["cantidad"].Value.ToString();
            }
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

        private void btnVerReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            Proveedor Form1 = new Proveedor();
            Form1.Show();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {

            Form ventasForm = new Ventas();
           ventasForm.ShowDialog();
        }

        

       

        private void btnalertas_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=LAPTOP-CG8J6ADN\\SQLEXPRESS;Initial Catalog=SUPERMERCADO;Integrated Security=True; TrustServerCertificate=True";
            IAlertaRepository alertaRepo = new AlertaRepository(cs);
            AlertaService servicio = new AlertaService(alertaRepo);

            servicio.EjecutarVerificacion();

            var alertas = servicio.ConsultarAlertas();
            dgvalertas.DataSource = alertas;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}
