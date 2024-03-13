using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data;

using EstadoDeCuentas.Datos;
using EstadoDeCuentas.Logica;

namespace EstadoDeCuentas.Presentacion
{
    public partial class EstadoCuenta : Form
    {

        IngresosDatos conn;
        public EstadoCuenta()
        {
            conn = new IngresosDatos(); 
            InitializeComponent();

            MostrarIngresos();
        }



        public void MostrarIngresos()
        {
        }


        private void Ingresos_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresosBrutos_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Egresos egreso = new Egresos();
            egreso.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.Show();
        }
    }
}
