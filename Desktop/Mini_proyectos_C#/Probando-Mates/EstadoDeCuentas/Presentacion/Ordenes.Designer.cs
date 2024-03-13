namespace EstadoDeCuentas.Presentacion
{
    partial class Ordenes
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
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtEstadoPedido = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtContactoCliente = new System.Windows.Forms.TextBox();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dteFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nmcCantidad = new System.Windows.Forms.NumericUpDown();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTipodePago = new System.Windows.Forms.TextBox();
            this.nudPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.nudDescuento = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(765, 55);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(194, 26);
            this.txtNombreCliente.TabIndex = 2;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(1055, 55);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(193, 26);
            this.txtApellidoCliente.TabIndex = 4;
            // 
            // txtEstadoPedido
            // 
            this.txtEstadoPedido.Location = new System.Drawing.Point(204, 203);
            this.txtEstadoPedido.Name = "txtEstadoPedido";
            this.txtEstadoPedido.Size = new System.Drawing.Size(225, 26);
            this.txtEstadoPedido.TabIndex = 5;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(503, 203);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(189, 26);
            this.txtObservaciones.TabIndex = 6;
            // 
            // txtContactoCliente
            // 
            this.txtContactoCliente.Location = new System.Drawing.Point(204, 135);
            this.txtContactoCliente.Name = "txtContactoCliente";
            this.txtContactoCliente.Size = new System.Drawing.Size(225, 26);
            this.txtContactoCliente.TabIndex = 9;
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(204, 55);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(225, 28);
            this.cbxProducto.TabIndex = 10;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(503, 55);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(189, 28);
            this.cbxColor.TabIndex = 11;
            this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre Producto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1051, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellido Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Contacto Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de Compra:";
            // 
            // dteFechaCompra
            // 
            this.dteFechaCompra.Location = new System.Drawing.Point(503, 133);
            this.dteFechaCompra.Name = "dteFechaCompra";
            this.dteFechaCompra.Size = new System.Drawing.Size(189, 26);
            this.dteFechaCompra.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(762, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Precio Venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1051, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Descuento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Estado de Pedido:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Observaciones:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1051, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cantidad";
            // 
            // nmcCantidad
            // 
            this.nmcCantidad.Location = new System.Drawing.Point(1055, 207);
            this.nmcCantidad.Name = "nmcCantidad";
            this.nmcCantidad.Size = new System.Drawing.Size(193, 26);
            this.nmcCantidad.TabIndex = 24;
            this.nmcCantidad.ValueChanged += new System.EventHandler(this.nmcCantidad_ValueChanged);
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrdenes.Location = new System.Drawing.Point(0, 435);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.RowHeadersWidth = 62;
            this.dgvOrdenes.RowTemplate.Height = 28;
            this.dgvOrdenes.Size = new System.Drawing.Size(1753, 263);
            this.dgvOrdenes.TabIndex = 25;
            this.dgvOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Seleccionar);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(762, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tipo de pago:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(121, 292);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 93);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(388, 292);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(143, 93);
            this.btnBorrar.TabIndex = 29;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(24, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 26);
            this.txtID.TabIndex = 30;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(20, 32);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(30, 20);
            this.ID.TabIndex = 31;
            this.ID.Text = "ID:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(24, 135);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(137, 26);
            this.txtIdCliente.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "ID Cliente:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(640, 292);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(143, 93);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(892, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 93);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTipodePago
            // 
            this.txtTipodePago.Location = new System.Drawing.Point(765, 203);
            this.txtTipodePago.Name = "txtTipodePago";
            this.txtTipodePago.Size = new System.Drawing.Size(194, 26);
            this.txtTipodePago.TabIndex = 26;
            // 
            // nudPrecioVenta
            // 
            this.nudPrecioVenta.Location = new System.Drawing.Point(766, 133);
            this.nudPrecioVenta.Name = "nudPrecioVenta";
            this.nudPrecioVenta.Size = new System.Drawing.Size(193, 26);
            this.nudPrecioVenta.TabIndex = 40;
            this.nudPrecioVenta.ValueChanged += new System.EventHandler(this.nudPrecioVenta_ValueChanged);
            // 
            // nudDescuento
            // 
            this.nudDescuento.Location = new System.Drawing.Point(1055, 136);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(193, 26);
            this.nudDescuento.TabIndex = 41;
            this.nudDescuento.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
            // 
            // Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 698);
            this.Controls.Add(this.nudDescuento);
            this.Controls.Add(this.nudPrecioVenta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvOrdenes);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTipodePago);
            this.Controls.Add(this.nmcCantidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dteFechaCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.txtContactoCliente);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtEstadoPedido);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Name = "Ordenes";
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmcCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtEstadoPedido;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtContactoCliente;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dteFechaCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmcCantidad;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTipodePago;
        private System.Windows.Forms.NumericUpDown nudPrecioVenta;
        private System.Windows.Forms.NumericUpDown nudDescuento;
    }
}