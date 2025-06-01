using supermecadoelectronico.CLASES;
using supermecadoelectronico.CLASES.repositorios;
using supermecadoelectronico.CLASES.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermecadoelectronico
{
    public partial class Proveedor : Form
    {
        private readonly Proveedoresrepository _repo;
        private int? productoSeleccionadoId = null;

        public Proveedor()
        {
            InitializeComponent();
            var cadenaConexion = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            _repo = new Proveedoresrepository(cadenaConexion);
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProveedor.DataSource = _repo.ObtenerTodos();
            dgvProveedor.ClearSelection();
        }

        private void LimpiarCampos()
        {
            txtcontacto.Clear();
            txtproveedor.Clear();
            dgvProveedor.ClearSelection();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtcontacto.Text) || string.IsNullOrWhiteSpace(txtproveedor.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return false;
            }
            return true;
        }

        private void btnguardarp_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var proveedores = new Proveedores()
                {
                    Contacto = txtcontacto.Text,
                    Nombre = txtproveedor.Text
                };

                _repo.Insertar(proveedores); // Uso directo del repositorio
                CargarProductos();
                LimpiarCampos();
            }
        }

        private void btnactualizarp_Click(object sender, EventArgs e)
        {
            if (productoSeleccionadoId.HasValue && ValidarCampos())
            {
                var proveedores = new Proveedores()
                {
                    ProveedorID = productoSeleccionadoId.Value,
                    Contacto = txtcontacto.Text,
                    Nombre = txtproveedor.Text
                };

                _repo.Actualizar(proveedores);
                CargarProductos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona un proveedor para actualizar.");
            }
        }

        private void btnelimanrp_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbuscarproveedor.Text, out int proveedorId))
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _repo.Eliminar(proveedorId);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido en el campo de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscarp_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtbuscarproveedor.Text, out id))
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-CG8J6ADN\\SQLEXPRESS;Initial Catalog=SUPERMERCADO;Integrated Security=True; TrustServerCertificate=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PROVEEDORES WHERE PROVEDORID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtproveedor.Text = reader["Nombre"].ToString();
                        txtcontacto.Text = reader["Contacto"].ToString();
                        txtidproducto.Text = reader["productoid"].ToString();
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
    }

}
