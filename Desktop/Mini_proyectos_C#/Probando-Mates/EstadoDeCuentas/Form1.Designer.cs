namespace EstadoDeCuentas
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
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.Location = new System.Drawing.Point(54, 36);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(169, 84);
            this.btnOrdenes.TabIndex = 0;
            this.btnOrdenes.Text = "Ingresar Venta";
            this.btnOrdenes.UseVisualStyleBackColor = true;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(309, 36);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(164, 84);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Ver Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(54, 168);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(169, 92);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Catalogo";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.Location = new System.Drawing.Point(309, 168);
            this.btnCuentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(157, 92);
            this.btnCuentas.TabIndex = 3;
            this.btnCuentas.Text = "Estado de Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnCuentas);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnOrdenes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCuentas;
    }
}

