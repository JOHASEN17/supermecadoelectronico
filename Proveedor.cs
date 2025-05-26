using supermecadoelectronico.CLASES;
using supermecadoelectronico.CLASES.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private readonly IUnitOfWork _uow = new UnitOfWorkproveedor();
        private int? productoSeleccionadoId = null;
        private int? productoSeleccionadoId1 = null;
        public Proveedor()
        {
            InitializeComponent();

        }
        private void CargarProductos()
        {
            dgvProveedor.DataSource = _uow.Proveedoresrepository.ObtenerTodos();
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
        private void Proveedor_Load(object sender, EventArgs e)
        {

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
                

                _uow.Proveedoresrepository.Insertar(proveedores);
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
                    Contacto = txtcontacto.Text,
                    Nombre = txtproveedor.Text
                };

                _uow.Proveedoresrepository.Actualizar(proveedores);
                CargarProductos();
                LimpiarCampos();
            }
        }

        private void btnelimanrp_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbuscarproveedor.Text, out int productoId))
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _uow.Proveedoresrepository.Eliminar(productoId);
                    CargarProductos();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido en el campo de búsqueda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
