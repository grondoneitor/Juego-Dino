namespace EstadoDeCuentas.Presentacion
{
    partial class CategoriaGastos
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
            this.dgvCategoriaGastos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoriaGastos
            // 
            this.dgvCategoriaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriaGastos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCategoriaGastos.Location = new System.Drawing.Point(0, 214);
            this.dgvCategoriaGastos.Name = "dgvCategoriaGastos";
            this.dgvCategoriaGastos.RowHeadersWidth = 62;
            this.dgvCategoriaGastos.RowTemplate.Height = 28;
            this.dgvCategoriaGastos.Size = new System.Drawing.Size(800, 236);
            this.dgvCategoriaGastos.TabIndex = 0;
            // 
            // CategoriaGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCategoriaGastos);
            this.Name = "CategoriaGastos";
            this.Text = "CategoriaGastos";
            this.Load += new System.EventHandler(this.CategoriaGastos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriaGastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoriaGastos;
    }
}