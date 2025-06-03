namespace supermecadoelectronico
{
    partial class Proveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguardarp = new System.Windows.Forms.Button();
            this.btnbuscarp = new System.Windows.Forms.Button();
            this.btnelimanrp = new System.Windows.Forms.Button();
            this.btnactualizarp = new System.Windows.Forms.Button();
            this.txtbuscarproveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(375, 90);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(379, 208);
            this.dgvProveedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PROVEEDOR";
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(60, 298);
            this.txtproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(215, 22);
            this.txtproveedor.TabIndex = 3;
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(61, 232);
            this.txtcontacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(215, 22);
            this.txtcontacto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTACTO";
            // 
            // btnguardarp
            // 
            this.btnguardarp.BackColor = System.Drawing.Color.Green;
            this.btnguardarp.Location = new System.Drawing.Point(53, 354);
            this.btnguardarp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardarp.Name = "btnguardarp";
            this.btnguardarp.Size = new System.Drawing.Size(109, 39);
            this.btnguardarp.TabIndex = 6;
            this.btnguardarp.Text = "GUARDAR";
            this.btnguardarp.UseVisualStyleBackColor = false;
            this.btnguardarp.Click += new System.EventHandler(this.btnguardarp_Click);
            // 
            // btnbuscarp
            // 
            this.btnbuscarp.BackColor = System.Drawing.Color.Yellow;
            this.btnbuscarp.Location = new System.Drawing.Point(169, 354);
            this.btnbuscarp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscarp.Name = "btnbuscarp";
            this.btnbuscarp.Size = new System.Drawing.Size(109, 39);
            this.btnbuscarp.TabIndex = 7;
            this.btnbuscarp.Text = "BUSCAR";
            this.btnbuscarp.UseVisualStyleBackColor = false;
            this.btnbuscarp.Click += new System.EventHandler(this.btnbuscarp_Click_1);
            // 
            // btnelimanrp
            // 
            this.btnelimanrp.BackColor = System.Drawing.Color.Red;
            this.btnelimanrp.Location = new System.Drawing.Point(284, 354);
            this.btnelimanrp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnelimanrp.Name = "btnelimanrp";
            this.btnelimanrp.Size = new System.Drawing.Size(109, 39);
            this.btnelimanrp.TabIndex = 8;
            this.btnelimanrp.Text = "ELIMINAR";
            this.btnelimanrp.UseVisualStyleBackColor = false;
            this.btnelimanrp.Click += new System.EventHandler(this.btnelimanrp_Click);
            // 
            // btnactualizarp
            // 
            this.btnactualizarp.BackColor = System.Drawing.Color.Orange;
            this.btnactualizarp.Location = new System.Drawing.Point(399, 354);
            this.btnactualizarp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnactualizarp.Name = "btnactualizarp";
            this.btnactualizarp.Size = new System.Drawing.Size(109, 39);
            this.btnactualizarp.TabIndex = 9;
            this.btnactualizarp.Text = "ACTUALIZAR";
            this.btnactualizarp.UseVisualStyleBackColor = false;
            this.btnactualizarp.Click += new System.EventHandler(this.btnactualizarp_Click);
            // 
            // txtbuscarproveedor
            // 
            this.txtbuscarproveedor.Location = new System.Drawing.Point(61, 91);
            this.txtbuscarproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbuscarproveedor.Name = "txtbuscarproveedor";
            this.txtbuscarproveedor.Size = new System.Drawing.Size(215, 22);
            this.txtbuscarproveedor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "BUSCAR";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(59, 157);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(215, 22);
            this.txtidproducto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "IDPRODUCTO";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbuscarproveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnactualizarp);
            this.Controls.Add(this.btnelimanrp);
            this.Controls.Add(this.btnbuscarp);
            this.Controls.Add(this.btnguardarp);
            this.Controls.Add(this.txtcontacto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProveedor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguardarp;
        private System.Windows.Forms.Button btnbuscarp;
        private System.Windows.Forms.Button btnelimanrp;
        private System.Windows.Forms.Button btnactualizarp;
        private System.Windows.Forms.TextBox txtbuscarproveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label label5;
    }
}
