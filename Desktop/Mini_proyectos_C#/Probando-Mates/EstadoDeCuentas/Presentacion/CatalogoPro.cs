using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EstadoDeCuentas.Presentacion;

namespace EstadoDeCuentas.Presentacion
{
    public partial class CatalogoPro : Form
    {
        public CatalogoPro()
        {
            InitializeComponent();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }
    }
}
