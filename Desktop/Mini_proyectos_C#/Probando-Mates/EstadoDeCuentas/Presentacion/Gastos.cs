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
using EstadoDeCuentas.Logica;


namespace EstadoDeCuentas.Presentacion
{
    public partial class Gastos : Form
    {

        GastosDatos conn;
        public Gastos()
        {
            conn = new GastosDatos();
            InitializeComponent();
            Mostrar();
            Botones();
        }

        //AGREGAR
        private void button1_Click(object sender, EventArgs e)
        {
            conn.AgregandoGasto(TomarDatos());
            Mostrar();
            Limpiar();
            Botones();

        }
        //BORRAR
        private void button2_Click(object sender, EventArgs e)
        {
            conn.BorrandoGasto(TomarDatos());
            Mostrar();
            Limpiar();
            Botones();
        }

        //MODIFICAR
        private void button3_Click(object sender, EventArgs e)
        {
            conn.ModificandoGasto(TomarDatos());
            Mostrar();
            Limpiar();
            Botones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones();
        }

        public void Mostrar() {
            dgvGastos.DataSource = conn.MostrandoGastos().Tables[0];

        }


        public GastosLogica TomarDatos()
        {
            GastosLogica gastosLogica = new GastosLogica();

            int ID = 0;
            int.TryParse(txtID.Text, out ID);
            gastosLogica.ID = ID;

            gastosLogica.IdCategoria = cmbCategoria.Text;


            gastosLogica.Nombre = txtNombre.Text;

            gastosLogica.Fecha = DateTime.Parse(dtpFecha.Text);




            int total = 0;
            int.TryParse(nudTotal.Text, out total);
            gastosLogica.TotalGasto = total;

          
            int cant = 0;
            int.TryParse(nudCantidad.Text, out cant);
            gastosLogica.Cantidad = cant;


            int uni = 0;
            int.TryParse(nudUnidad.Text, out uni);
            gastosLogica.GastoUnidad = uni;





            gastosLogica.Observaciones = txtObservaciones.Text;
            
            return gastosLogica;
        }
        private void Gastos_Load(object sender, EventArgs e)
        {
            CategoriaGastosDatos catGastosDatos = new CategoriaGastosDatos();
            DataSet dataSet = catGastosDatos.MostrarCategorias();

            cmbCategoria.DataSource = dataSet.Tables[0];
            cmbCategoria.DisplayMember = "Categoria";
            cmbCategoria.ValueMember = "IdCategoriaGasto";


        }
        // SELECCIONAR  
        private void dgvGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            dgvGastos.ClearSelection();

            txtID.Text = dgvGastos.Rows[indice].Cells[0].Value.ToString();
            cmbCategoria.Text = dgvGastos.Rows[indice].Cells[1].Value.ToString();
            txtNombre.Text = dgvGastos.Rows[indice].Cells[2].Value.ToString();
            dtpFecha.Text = dgvGastos.Rows[indice].Cells[3].Value.ToString();
            nudTotal.Text = dgvGastos.Rows[indice].Cells[4].Value.ToString();
            nudCantidad.Text = dgvGastos.Rows[indice].Cells[5].Value.ToString();
            nudUnidad.Text = dgvGastos.Rows[indice].Cells[6].Value.ToString();
            txtObservaciones.Text = dgvGastos.Rows[indice].Cells[7].Value.ToString();



            int IdCatSelecc = Convert.ToInt32(dgvGastos.Rows[indice].Cells[1].Value);

            DataSet data = conn.MostrandoCategoriaGastos(IdCatSelecc.ToString());

            if (data != null && data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                cmbCategoria.Text = data.Tables[0].Rows[0]["Categoria"].ToString();



            }

            btnAgregar.Enabled = false;
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;


        }


        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            nudCantidad.Maximum = 10000000;
            nudCantidad.Minimum = 0;
        }
        private void nudUnidad_ValueChanged(object sender, EventArgs e)
        {
            nudUnidad.Maximum = 10000000;
            nudUnidad.Minimum = 0;
        }
        private void nudTotal_ValueChanged(object sender, EventArgs e)
        {
            nudTotal.Maximum = 100000000;
            nudTotal.Minimum = 0;
        }

        public void Limpiar()
        {
            txtID.Text = "";
            cmbCategoria.Text = "";
            txtNombre.Text = "";
            nudTotal.Text = "";
            nudCantidad.Text = "";
            nudUnidad.Text = "";
            txtObservaciones.Text = "";


        }
        public void Botones()
        {
            btnAgregar.Enabled = true;
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;  

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

  

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
