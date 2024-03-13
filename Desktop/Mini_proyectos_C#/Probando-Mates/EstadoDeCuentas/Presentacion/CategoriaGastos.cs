using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EstadoDeCuentas.Datos;


namespace EstadoDeCuentas.Presentacion
{
    public partial class CategoriaGastos : Form
    {
        CategoriaGastosDatos conn;
        public CategoriaGastos()
        { 
            conn = new CategoriaGastosDatos();

            InitializeComponent();
        }

        private void CategoriaGastos_Load(object sender, EventArgs e)
        {
            dgvCategoriaGastos.DataSource = conn.MostrarCategorias().Tables[0];

        }
    }
}
