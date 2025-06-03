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
        private readonly IUnitOfWork _uow = new UnitOfWork();
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
            try
            {
                dgvProveedor.DataSource = _uow.Proveedoresrepository.ObtenerTodos();
                dgvProveedor.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtidproducto.Clear();
            txtcontacto.Clear();
            txtproveedor.Clear();
            dgvProveedor.ClearSelection();
        }

        private bool ValidarCampos()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtcontacto.Text) || string.IsNullOrWhiteSpace(txtproveedor.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos.");
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

        private void btnguardarp_Click(object sender, EventArgs e)
        {
            try { 
            if (ValidarCampos())
            {
                var proveedores = new Proveedores()
                {
                    Contacto = txtcontacto.Text,
                    Nombre = txtproveedor.Text,
                    IDProductos = int.Parse(txtidproducto.Text)

                };

                _uow.Proveedoresrepository.Insertar(proveedores); 
                CargarProductos();
                LimpiarCampos();

                MessageBox.Show("Proveedor guardado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar proveedor: " + ex.Message);
            }
        }

        private void btnactualizarp_Click(object sender, EventArgs e)
        {
            try
            {
                if (productoSeleccionadoId.HasValue && ValidarCampos())
                {
                    var proveedores = new Proveedores()
                    {
                        ProveedorID = productoSeleccionadoId.Value,
                        Contacto = txtcontacto.Text,
                        Nombre = txtproveedor.Text
                    };

                    _uow.Proveedoresrepository.Actualizar(proveedores);
                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Selecciona un proveedor para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar proveedor: " + ex.Message);
            }
        }

        private void btnelimanrp_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbuscarproveedor.Text, out int proveedorId))
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _uow.Proveedoresrepository.Eliminar(proveedorId);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido en el campo de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnbuscarp_Click_1(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar proveedor: " + ex.Message);
            }
        }
    }

}
