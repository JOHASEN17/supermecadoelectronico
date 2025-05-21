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
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.MARCA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblModo = new System.Windows.Forms.Label();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnproveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(45, 135);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 22);
            this.txtmarca.TabIndex = 0;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(45, 188);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 22);
            this.txtModelo.TabIndex = 1;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(45, 250);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 22);
            this.txtcantidad.TabIndex = 2;
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
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(45, 319);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "PEDIDOS ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(73, 371);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 30);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Location = new System.Drawing.Point(502, 371);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(123, 30);
            this.btnVerReportes.TabIndex = 11;
            this.btnVerReportes.Text = "REPORTES";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.btnVerReportes_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(355, 371);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(123, 30);
            this.btnAgregarProveedor.TabIndex = 12;
            this.btnAgregarProveedor.Text = "AGREGAR";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(217, 371);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(123, 30);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(734, 9);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(0, 16);
            this.lblModo.TabIndex = 14;
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(273, 66);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.RowHeadersWidth = 51;
            this.dtgProductos.RowTemplate.Height = 24;
            this.dtgProductos.Size = new System.Drawing.Size(678, 259);
            this.dtgProductos.TabIndex = 15;
            this.dtgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellContentClick);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(651, 371);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(123, 30);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "LIMPIAR";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(806, 371);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(123, 30);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(45, 78);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 22);
            this.txtbuscar.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "buscar por id";
            // 
            // btnproveedor
            // 
            this.btnproveedor.Location = new System.Drawing.Point(737, 443);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Size = new System.Drawing.Size(123, 30);
            this.btnproveedor.TabIndex = 20;
            this.btnproveedor.Text = "PROVEEDOR";
            this.btnproveedor.UseVisualStyleBackColor = true;
            this.btnproveedor.Click += new System.EventHandler(this.btnproveedor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 485);
            this.Controls.Add(this.btnproveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.btnVerReportes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MARCA);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtmarca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label MARCA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnproveedor;
    }
}

