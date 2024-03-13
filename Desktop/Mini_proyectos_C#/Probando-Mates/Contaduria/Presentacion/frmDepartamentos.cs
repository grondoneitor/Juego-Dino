using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Contaduria.Datos;
using Contaduria.Logic;



namespace Contaduria.Presentacion
{
    public partial class frmDepartamentos : Form
    {
        DepartamentoDatos cone;

        public frmDepartamentos()
        {
            cone = new DepartamentoDatos();

            InitializeComponent();
            LimpiarEntradas();
            Mostrar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
      
            cone.Agregarr(FuncionAgregar());
            Mostrar();
            LimpiarEntradas();
        }
        public void btnBorrar_Click(object sender, EventArgs e)
        {
             cone.Borrarr(FuncionAgregar()) ;
            Mostrar();
            LimpiarEntradas();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
           cone.Modificar(FuncionAgregar());
            Mostrar();

            LimpiarEntradas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarEntradas();
        }

        private DepartamentoLogic FuncionAgregar()
        {
            DepartamentoLogic departamentoLogic = new DepartamentoLogic();

            int ID = 0; int.TryParse(txtID.Text, out ID);

            departamentoLogic.ID = ID;
            departamentoLogic.Departamento = txtNombreDepartamento.Text;

            LimpiarEntradas();

            return departamentoLogic;

        }

         public void Mostrar()
        {
            dgvDepartamentos.DataSource = cone.MostrarDepa().Tables[0];


            dgvDepartamentos.Columns[0].HeaderText = "ID";
            dgvDepartamentos.Columns[1].HeaderText = "Nombre Departamento";

        }



        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvDepartamentos.ClearSelection();

            if (indice >= 0)
            {
                txtID.Text = dgvDepartamentos.Rows[indice].Cells[0].Value.ToString();
                txtNombreDepartamento.Text = dgvDepartamentos.Rows[indice].Cells[1].Value.ToString();

                btnAgregar.Enabled = false;
                btnBorrar.Enabled = true;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }

        

        private void LimpiarEntradas()
        {
            txtID.Text = "";
            txtNombreDepartamento.Text = "";

            btnAgregar.Enabled = true;
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;    

        }


        private void frmDepartamentos_Load(object sender, EventArgs e)
        {

        }

        private void dgvDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
