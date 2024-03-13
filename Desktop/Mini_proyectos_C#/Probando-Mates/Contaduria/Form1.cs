using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Contaduria.Presentacion;

namespace Contaduria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDepartamentos frmDepartamentos = new frmDepartamentos();

            frmDepartamentos.Show();
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frmEmpleados = new frmEmpleados();

            frmEmpleados.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
