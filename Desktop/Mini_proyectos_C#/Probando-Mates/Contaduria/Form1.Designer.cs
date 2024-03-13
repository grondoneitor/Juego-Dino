namespace Contaduria
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
            this.Departamento = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Departamento
            // 
            this.Departamento.Image = global::Contaduria.Properties.Resources._2668_advanced_settings_setup_tools_icon;
            this.Departamento.Location = new System.Drawing.Point(124, 94);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(231, 227);
            this.Departamento.TabIndex = 0;
            this.Departamento.Text = "Departamento";
            this.Departamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Departamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Departamento.UseVisualStyleBackColor = true;
            this.Departamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Image = global::Contaduria.Properties.Resources._285641_id_user_icon;
            this.btnEmpleados.Location = new System.Drawing.Point(422, 94);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(231, 227);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.Departamento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Departamento;
        private System.Windows.Forms.Button btnEmpleados;
    }
}

