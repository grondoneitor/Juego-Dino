namespace Probando_Mates2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Nombre = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.Enviar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.DataGridView();
            this.Contacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(56, 25);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(65, 20);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(56, 74);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(65, 20);
            this.Apellido.TabIndex = 1;
            this.Apellido.Text = "Apellido";
            this.Apellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(163, 74);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(245, 26);
            this.txtApellido.TabIndex = 4;
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(442, 25);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(146, 132);
            this.Enviar.TabIndex = 5;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = true;
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(622, 25);
            this.Borrar.Name = "Borrar";
            this.Borrar.Padding = new System.Windows.Forms.Padding(1);
            this.Borrar.Size = new System.Drawing.Size(146, 132);
            this.Borrar.TabIndex = 6;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            // 
            // Lista
            // 
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lista.Location = new System.Drawing.Point(0, 250);
            this.Lista.Name = "Lista";
            this.Lista.RowHeadersWidth = 62;
            this.Lista.RowTemplate.Height = 28;
            this.Lista.Size = new System.Drawing.Size(800, 200);
            this.Lista.TabIndex = 7;
            // 
            // Contacto
            // 
            this.Contacto.AutoSize = true;
            this.Contacto.Location = new System.Drawing.Point(56, 123);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(74, 20);
            this.Contacto.TabIndex = 8;
            this.Contacto.Text = "Contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(163, 123);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(245, 26);
            this.txtContacto.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.Contacto);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.DataGridView Lista;
        private System.Windows.Forms.Label Contacto;
        private System.Windows.Forms.TextBox txtContacto;
    }
}

