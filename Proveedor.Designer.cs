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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(375, 90);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(378, 208);
            this.dgvProveedor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "PROVEEDOR";
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(42, 122);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(214, 22);
            this.txtproveedor.TabIndex = 3;
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(42, 193);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(214, 22);
            this.txtcontacto.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTACTO";
            // 
            // btnguardarp
            // 
            this.btnguardarp.Location = new System.Drawing.Point(54, 355);
            this.btnguardarp.Name = "btnguardarp";
            this.btnguardarp.Size = new System.Drawing.Size(109, 39);
            this.btnguardarp.TabIndex = 6;
            this.btnguardarp.Text = "GUARDAR";
            this.btnguardarp.UseVisualStyleBackColor = true;
            // 
            // btnbuscarp
            // 
            this.btnbuscarp.Location = new System.Drawing.Point(169, 355);
            this.btnbuscarp.Name = "btnbuscarp";
            this.btnbuscarp.Size = new System.Drawing.Size(109, 39);
            this.btnbuscarp.TabIndex = 7;
            this.btnbuscarp.Text = "BUSCAR";
            this.btnbuscarp.UseVisualStyleBackColor = true;
            // 
            // btnelimanrp
            // 
            this.btnelimanrp.Location = new System.Drawing.Point(284, 355);
            this.btnelimanrp.Name = "btnelimanrp";
            this.btnelimanrp.Size = new System.Drawing.Size(109, 39);
            this.btnelimanrp.TabIndex = 8;
            this.btnelimanrp.Text = "ELIMINAR";
            this.btnelimanrp.UseVisualStyleBackColor = true;
            // 
            // btnactualizarp
            // 
            this.btnactualizarp.Location = new System.Drawing.Point(399, 355);
            this.btnactualizarp.Name = "btnactualizarp";
            this.btnactualizarp.Size = new System.Drawing.Size(109, 39);
            this.btnactualizarp.TabIndex = 9;
            this.btnactualizarp.Text = "ACTUALIZAR";
            this.btnactualizarp.UseVisualStyleBackColor = true;
            // 
            // btnform1
            // 
            this.btnform1.Location = new System.Drawing.Point(655, 379);
            this.btnform1.Name = "btnform1";
            this.btnform1.Size = new System.Drawing.Size(109, 39);
            this.btnform1.TabIndex = 10;
            this.btnform1.Text = "PEDIDOS";
            this.btnform1.UseVisualStyleBackColor = true;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}