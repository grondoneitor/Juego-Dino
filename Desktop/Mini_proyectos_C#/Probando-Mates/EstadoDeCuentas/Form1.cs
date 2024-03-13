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


namespace EstadoDeCuentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            Ordenes ordenes = new Ordenes();

            ordenes.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes(); 
            clientes.Show();    
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            CatalogoPro CataProductos = new CatalogoPro();
            CataProductos.Show();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            EstadoCuenta ingresos = new EstadoCuenta();    
              ingresos.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
