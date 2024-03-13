using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Contaduria.Datos;
using Contaduria.Logic;
using Contaduria.Presentacion;


namespace Contaduria.Presentacion
{
    public partial class frmEmpleados : Form
    {
        EmpleadosDatos cone;

      //  byte[] ImgByte;
        public frmEmpleados()
        {

            cone = new EmpleadosDatos();
            InitializeComponent();
            Mostrar();
            Limpiar();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void btnAgregar_Click(object sender, EventArgs e)
        {


            cone.Agregar(FuncionAgregar());
            Mostrar();
            Limpiar();

        }

        public void btnBorrar_Click(object sender, EventArgs e)
        {

            cone.Borrar(FuncionAgregar());
            Mostrar();
            Limpiar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          
            cone.Modificar(FuncionAgregar());
            Mostrar();
            Limpiar();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }
        /*        private void cbxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
                {
                   DepartamentoDatos depaDatos = new DepartamentoDatos();
                   DataSet dataSet = depaDatos.MostrarDepa();

                    cbxDepartamento.Items.Add(1);
                    cbxDepartamento.DataSource = dataSet.Tables[0];
                    cbxDepartamento.DisplayMember = "Departamento";
                    cbxDepartamento.ValueMember = "IdDepartamento";

                     }
        */
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            DepartamentoDatos depaDatos = new DepartamentoDatos();
            DataSet dataSet = depaDatos.MostrarDepa();

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                // Se encontraron datos
                cbxDepartamento.DataSource = dataSet.Tables[0];
                cbxDepartamento.DisplayMember = "Departamento";
                cbxDepartamento.ValueMember = "IdDepartamento";
            }
            else
            {
                // No se encontraron datos o hubo un problema con la consulta
                MessageBox.Show("No se encontraron datos de departamentos.");
            }

         

        }

        private EmpleadosLogic FuncionAgregar()
        {
            EmpleadosLogic empleadosLogic = new EmpleadosLogic();

            int ID = 1;
            int.TryParse(txtID.Text, out ID);

            empleadosLogic.ID = ID;

            empleadosLogic.Nombre = txtNombre.Text;
            empleadosLogic.PrimerApellido = txtPrimerApellido.Text;
            empleadosLogic.SegundoApellido = txtSegundoApellido.Text;
            empleadosLogic.Mail = txtMail.Text;

            int Departamento = 0;
            int.TryParse(cbxDepartamento.SelectedValue.ToString(), out Departamento);
                        empleadosLogic.Departamento = Departamento;

               // empleadosLogic.Foto = ImgByte;

                return empleadosLogic;


            }
        



        private void Mostrar()
        {
            dgvEmpleados.DataSource = cone.MostrarEmps().Tables[0];
            dgvEmpleados.Columns[0].HeaderText = "ID";
            dgvEmpleados.Columns[1].HeaderText = "Nombre Empleado";
        }



        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            dgvEmpleados.ClearSelection();
            if (indice >= 0)
            {

                txtID.Text = dgvEmpleados.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvEmpleados.Rows[indice].Cells[1].Value.ToString();
                txtPrimerApellido.Text = dgvEmpleados.Rows[indice].Cells[2].Value.ToString();
                txtSegundoApellido.Text = dgvEmpleados.Rows[indice].Cells[3].Value.ToString();
                txtMail.Text = dgvEmpleados.Rows[indice].Cells[4].Value.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
                btnCancelar.Enabled = true;


            }                




        }

        private void Limpiar()
        {

            txtID.Text = "";
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtMail.Text = "";


            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;  
            btnCancelar.Enabled = false;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
/*            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK )
            {
                picFoto.Image = Image.FromStream(openFileDialog.OpenFile());

                MemoryStream memoria = new MemoryStream();

                picFoto.Image.Save(memoria,System.Drawing.Imaging.ImageFormat.Png );


                ImgByte= memoria.ToArray();
  
            }*/
        }
     

        private void picFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
