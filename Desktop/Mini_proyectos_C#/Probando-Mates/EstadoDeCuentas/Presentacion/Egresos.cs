using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadoDeCuentas.Presentacion
{
    public partial class Egresos : Form
    {
        public Egresos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gastos gastos = new Gastos();

            gastos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoriaGastos CATgastos = new CategoriaGastos();

             CATgastos.Show();
        }
    }
}
