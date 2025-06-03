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

        public Form1()
        {
            InitializeComponent();            
        }

        private void CargarProductos()
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar campos: " + ex.Message);
                return false;
            }
        }


        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
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

                    MessageBox.Show("se actualizo perfectamente.");

                    _uow.ProductoRepository.Actualizar(producto);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar producto: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
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

        private void btnalertas_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=LAPTOP-CG8J6ADN\\SQLEXPRESS;Initial Catalog=SUPERMERCADO;Integrated Security=True; TrustServerCertificate=True";
                IAlertaRepository alertaRepo = new AlertaRepository(cs);
                AlertaService servicio = new AlertaService(alertaRepo);

                servicio.EjecutarVerificacion();

                var alertas = servicio.ConsultarAlertas();
                dgvalertas.DataSource = alertas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alertas: " + ex.Message);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            CargarProductos();
            CargarProveedores();
        }


        private DataTable ObtenerHistorialComprasPorProveedor(int proveedorId)
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-CG8J6ADN\\SQLEXPRESS;Initial Catalog=SUPERMERCADO;Integrated Security=True; TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ObtenerHistorialComprasProveedor", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProveedorID", proveedorId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarProveedores()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-CG8J6ADN\\SQLEXPRESS;Initial Catalog=SUPERMERCADO;Integrated Security=True; TrustServerCertificate=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT PROVEDORID, NOMBRE FROM PROVEEDORES", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbProveedores.DataSource = dt;
                cmbProveedores.DisplayMember = "NOMBRE";
                cmbProveedores.ValueMember = "PROVEDORID";
                cmbProveedores.SelectedIndex = -1;
            }
        }

        private void btnVerHistorialCompras_Click_1(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedValue != null)
            {
                int proveedorId = Convert.ToInt32(cmbProveedores.SelectedValue);
                dgvHistorialCompras.DataSource = ObtenerHistorialComprasPorProveedor(proveedorId);
            }
            else
            {
                MessageBox.Show("Selecciona un proveedor.");
            }
        }

        private void dgvHistorialCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
