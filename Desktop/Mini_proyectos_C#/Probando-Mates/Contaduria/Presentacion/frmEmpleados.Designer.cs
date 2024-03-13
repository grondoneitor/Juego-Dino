namespace Contaduria.Presentacion
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SegundoApellido = new System.Windows.Forms.Label();
            this.PrimerApellido = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 388);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 62;
            this.dgvEmpleados.RowTemplate.Height = 28;
            this.dgvEmpleados.Size = new System.Drawing.Size(913, 203);
            this.dgvEmpleados.TabIndex = 38;
            this.dgvEmpleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Seleccionar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(737, 266);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 75);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::Contaduria.Properties.Resources._299045_sign_error_icon;
            this.btnBorrar.Location = new System.Drawing.Point(572, 266);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(144, 75);
            this.btnBorrar.TabIndex = 36;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::Contaduria.Properties.Resources._285657_floppy_guardar_save_icon;
            this.btnAgregar.Location = new System.Drawing.Point(239, 266);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 75);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::Contaduria.Properties.Resources._61653_edit_pen_write_icon;
            this.btnModificar.Location = new System.Drawing.Point(406, 266);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 75);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(0, 0);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Departamento";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(250, 131);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(37, 20);
            this.Mail.TabIndex = 30;
            this.Mail.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 29;
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.AutoSize = true;
            this.SegundoApellido.Location = new System.Drawing.Point(537, 68);
            this.SegundoApellido.Name = "SegundoApellido";
            this.SegundoApellido.Size = new System.Drawing.Size(134, 20);
            this.SegundoApellido.TabIndex = 28;
            this.SegundoApellido.Text = "Segundo Apellido";
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.AutoSize = true;
            this.PrimerApellido.Location = new System.Drawing.Point(250, 68);
            this.PrimerApellido.Name = "PrimerApellido";
            this.PrimerApellido.Size = new System.Drawing.Size(114, 20);
            this.PrimerApellido.TabIndex = 27;
            this.PrimerApellido.Text = "Primer Apellido";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(537, 7);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(65, 20);
            this.Nombre.TabIndex = 26;
            this.Nombre.Text = "Nombre";
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(254, 220);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(531, 28);
            this.cbxDepartamento.TabIndex = 25;
            this.cbxDepartamento.SelectedIndexChanged += new System.EventHandler(this.picFoto_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(252, 154);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(533, 26);
            this.txtMail.TabIndex = 24;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(540, 91);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(245, 26);
            this.txtSegundoApellido.TabIndex = 23;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(252, 91);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(257, 26);
            this.txtPrimerApellido.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(540, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 26);
            this.txtNombre.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(252, 26);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(259, 26);
            this.txtID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 591);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SegundoApellido);
            this.Controls.Add(this.PrimerApellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.cbxDepartamento);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SegundoApellido;
        private System.Windows.Forms.Label PrimerApellido;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}