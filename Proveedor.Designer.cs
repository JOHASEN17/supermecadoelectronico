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
            this.btnform1 = new System.Windows.Forms.Button();
            this.txtbuscarproveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(281, 73);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(284, 169);
            this.dgvProveedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PROVEEDOR";
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(32, 99);
            this.txtproveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(162, 20);
            this.txtproveedor.TabIndex = 3;
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(32, 157);
            this.txtcontacto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(162, 20);
            this.txtcontacto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTACTO";
            // 
            // btnguardarp
            // 
            this.btnguardarp.BackColor = System.Drawing.Color.Green;
            this.btnguardarp.Location = new System.Drawing.Point(40, 288);
            this.btnguardarp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnguardarp.Name = "btnguardarp";
            this.btnguardarp.Size = new System.Drawing.Size(82, 32);
            this.btnguardarp.TabIndex = 6;
            this.btnguardarp.Text = "GUARDAR";
            this.btnguardarp.UseVisualStyleBackColor = false;
            this.btnguardarp.Click += new System.EventHandler(this.btnguardarp_Click);
            // 
            // btnbuscarp
            // 
            this.btnbuscarp.BackColor = System.Drawing.Color.Yellow;
            this.btnbuscarp.Location = new System.Drawing.Point(127, 288);
            this.btnbuscarp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbuscarp.Name = "btnbuscarp";
            this.btnbuscarp.Size = new System.Drawing.Size(82, 32);
            this.btnbuscarp.TabIndex = 7;
            this.btnbuscarp.Text = "BUSCAR";
            this.btnbuscarp.UseVisualStyleBackColor = false;
            // 
            // btnelimanrp
            // 
            this.btnelimanrp.BackColor = System.Drawing.Color.Red;
            this.btnelimanrp.Location = new System.Drawing.Point(213, 288);
            this.btnelimanrp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnelimanrp.Name = "btnelimanrp";
            this.btnelimanrp.Size = new System.Drawing.Size(82, 32);
            this.btnelimanrp.TabIndex = 8;
            this.btnelimanrp.Text = "ELIMINAR";
            this.btnelimanrp.UseVisualStyleBackColor = false;
            this.btnelimanrp.Click += new System.EventHandler(this.btnelimanrp_Click);
            // 
            // btnactualizarp
            // 
            this.btnactualizarp.BackColor = System.Drawing.Color.Orange;
            this.btnactualizarp.Location = new System.Drawing.Point(299, 288);
            this.btnactualizarp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnactualizarp.Name = "btnactualizarp";
            this.btnactualizarp.Size = new System.Drawing.Size(82, 32);
            this.btnactualizarp.TabIndex = 9;
            this.btnactualizarp.Text = "ACTUALIZAR";
            this.btnactualizarp.UseVisualStyleBackColor = false;
            this.btnactualizarp.Click += new System.EventHandler(this.btnactualizarp_Click);
            // 
            // btnform1
            // 
            this.btnform1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnform1.Location = new System.Drawing.Point(491, 308);
            this.btnform1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnform1.Name = "btnform1";
            this.btnform1.Size = new System.Drawing.Size(82, 32);
            this.btnform1.TabIndex = 10;
            this.btnform1.Text = "PEDIDOS";
            this.btnform1.UseVisualStyleBackColor = false;
            // 
            // txtbuscarproveedor
            // 
            this.txtbuscarproveedor.Location = new System.Drawing.Point(32, 45);
            this.txtbuscarproveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbuscarproveedor.Name = "txtbuscarproveedor";
            this.txtbuscarproveedor.Size = new System.Drawing.Size(162, 20);
            this.txtbuscarproveedor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "BUSCAR";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtbuscarproveedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnform1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnform1;
        private System.Windows.Forms.TextBox txtbuscarproveedor;
        private System.Windows.Forms.Label label4;
    }
}
