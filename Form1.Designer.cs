namespace supermecadoelectronico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MARCA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnproveedor = new System.Windows.Forms.Button();
            this.btnalertas = new System.Windows.Forms.Button();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.dgvalertas = new System.Windows.Forms.DataGridView();
            this.btnventas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalertas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(45, 78);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 22);
            this.txtbuscar.TabIndex = 18;
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(45, 135);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 22);
            this.txtmarca.TabIndex = 0;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(45, 188);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 1;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(45, 250);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 22);
            this.txtcantidad.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(45, 319);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "buscar por id";
            // 
            // MARCA
            // 
            this.MARCA.AutoSize = true;
            this.MARCA.Location = new System.Drawing.Point(45, 113);
            this.MARCA.Name = "MARCA";
            this.MARCA.Size = new System.Drawing.Size(55, 16);
            this.MARCA.TabIndex = 3;
            this.MARCA.Text = "MARCA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "MODELO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "CANTIDAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "PRECIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "PEDIDOS ";
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(731, 50);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(0, 16);
            this.lblModo.TabIndex = 14;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(832, 263);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 24;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Yellow;
            this.btnbuscar.Location = new System.Drawing.Point(691, 59);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(123, 30);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(691, 251);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 30);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.Green;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(691, 107);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(123, 30);
            this.btnAgregarProveedor.TabIndex = 12;
            this.btnAgregarProveedor.Text = "AGREGAR";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Green;
            this.btnActualizar.Location = new System.Drawing.Point(691, 155);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(123, 30);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Red;
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlimpiar.Location = new System.Drawing.Point(691, 203);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(123, 30);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnproveedor
            // 
            this.btnproveedor.BackColor = System.Drawing.Color.Yellow;
            this.btnproveedor.Location = new System.Drawing.Point(691, 496);
            this.btnproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Size = new System.Drawing.Size(123, 30);
            this.btnproveedor.TabIndex = 20;
            this.btnproveedor.Text = "PROVEEDOR";
            this.btnproveedor.UseVisualStyleBackColor = false;
            this.btnproveedor.Click += new System.EventHandler(this.btnproveedor_Click);
            // 
            // btnalertas
            // 
            this.btnalertas.BackColor = System.Drawing.Color.Red;
            this.btnalertas.Location = new System.Drawing.Point(691, 299);
            this.btnalertas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnalertas.Name = "btnalertas";
            this.btnalertas.Size = new System.Drawing.Size(123, 63);
            this.btnalertas.TabIndex = 26;
            this.btnalertas.Text = "ALERTAS";
            this.btnalertas.UseVisualStyleBackColor = false;
            this.btnalertas.Click += new System.EventHandler(this.btnalertas_Click);
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(171, 59);
            this.dtgProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.RowHeadersWidth = 51;
            this.dtgProductos.RowTemplate.Height = 24;
            this.dtgProductos.Size = new System.Drawing.Size(499, 282);
            this.dtgProductos.TabIndex = 15;
            this.dtgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellContentClick);
            // 
            // dgvalertas
            // 
            this.dgvalertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalertas.Location = new System.Drawing.Point(171, 370);
            this.dgvalertas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvalertas.Name = "dgvalertas";
            this.dgvalertas.RowHeadersWidth = 51;
            this.dgvalertas.RowTemplate.Height = 24;
            this.dgvalertas.Size = new System.Drawing.Size(499, 188);
            this.dgvalertas.TabIndex = 25;
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.Green;
            this.btnventas.Location = new System.Drawing.Point(691, 462);
            this.btnventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(123, 30);
            this.btnventas.TabIndex = 21;
            this.btnventas.Text = "VENDER";
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(873, 584);
            this.Controls.Add(this.btnalertas);
            this.Controls.Add(this.dgvalertas);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.btnproveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MARCA);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtmarca);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label MARCA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Button btnproveedor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvalertas;
        private System.Windows.Forms.Button btnalertas;
        private System.Windows.Forms.Button btnventas;
    }
}

