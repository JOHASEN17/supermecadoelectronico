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
    public partial class Form1 : Form
    {
        private bool esAdmin;

        public Form1(bool esAdmin)
        {
            InitializeComponent();
            this.esAdmin = esAdmin;

            AplicarPermisos();
        }

        private void AplicarPermisos()
        {
            if (!esAdmin)
            {
                // Ocultar o deshabilitar funciones que solo un administrador puede usar
                btnEliminar.Visible = false;
                btnActualizar.Visible = false;
                btnAgregarProveedor.Visible = false;
                btnVerReportes.Visible = false;

                // O deshabilitarlos si prefieres:
                // btnEliminar.Enabled = false;
                // btnActualizar.Enabled = false;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
