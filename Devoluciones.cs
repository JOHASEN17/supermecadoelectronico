using supermecadoelectronico.CLASES.services;
using supermecadoelectronico.CLASES.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermecadoelectronico
{
    public partial class Devoluciones : Form
    {
        private readonly IUnitOfWork _uow = new UnitOfWork();
        private readonly bool esAdmin;
        public Devoluciones()
        {
            InitializeComponent();
            CargarProductosGrid();
        }

        private void CargarProductosGrid()
        {
            try
            {
                dgvVentas.DataSource = _uow.VentaService.ObtenerTodos();
                dgvVentas.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {

            if (!esAdmin)
            {
                MessageBox.Show("Solo un administrador puede autorizar devoluciones.");
                return;
            }

            if (!int.TryParse(txtProductoID.Text, out int idProducto) ||
                !int.TryParse(txtCantidad.Text, out int cantidad) ||
                string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show("Complete todos los campos correctamente.");
                return;
            }

            var devolucion = new Devolucion
            {
                IdProducto = Convert.ToInt32(txtProductoID.Text),
                CantidadDevuelta = Convert.ToInt32(txtCantidad.Text),
                Motivo = txtMotivo.Text
            };

            _uow.DevolucionRepository.RegistrarDevolucion(devolucion);

            MessageBox.Show("Devolución registrada correctamente.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Devoluciones_Load(object sender, EventArgs e)
        {

        }
    }
}
