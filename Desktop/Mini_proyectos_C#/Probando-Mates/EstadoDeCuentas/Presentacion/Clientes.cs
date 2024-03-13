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
    public partial class Clientes : Form
    {

        List<ClienteLogica> datos = new List<ClienteLogica>();

        ClienteDatos clienteDatos;

        public Clientes()
        {
            clienteDatos = new ClienteDatos();
            InitializeComponent();
            ClientesMostrar();
            Botones();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            clienteDatos.Agregar(TomandoDatos());
            Limpiar();
            ClientesMostrar();
            Botones();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            clienteDatos.Borrar(TomandoDatos());
            Limpiar();
            ClientesMostrar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            clienteDatos.Modificar(TomandoDatos());
            Limpiar();
            ClientesMostrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones();
        }

        private void ClientesMostrar()
        {
            dgvClientes.DataSource = clienteDatos.MostrarCliente().Tables[0];

            foreach (var item in datos)
            {
                dgvClientes.Rows.Add(item.IdCliente, item.NombreCliente, item.ApellidoCliente, item.Contacto); 
            }

        }

        private void Limpiar()
        {
            txtID.Text = null;
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtContacto.Text = "";
        }

        public ClienteLogica TomandoDatos()
        {
            ClienteLogica clientesLogica = new ClienteLogica();

            int ID = 0;
            int.TryParse(txtID.Text,out ID);
            clientesLogica.IdCliente= ID;
            clientesLogica.NombreCliente = txtNombreCliente.Text;
            clientesLogica.ApellidoCliente = txtApellidoCliente.Text;
            clientesLogica.Contacto = txtContacto.Text;

            return clientesLogica;

        }

        //SELECCIONARR
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            dgvClientes.ClearSelection();

            if (indice >= 0)
            {
                txtID.Text = dgvClientes.Rows[indice].Cells[0].Value.ToString();
                txtNombreCliente.Text = dgvClientes.Rows[indice].Cells[1].Value.ToString();
                txtApellidoCliente.Text = dgvClientes.Rows[indice].Cells[2].Value.ToString();
                txtContacto.Text = dgvClientes.Rows[indice].Cells[3].Value.ToString();


                btnAgregarCliente.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
                btnCancelar.Enabled = true;
            }

        }




        private void Botones()
        {
            btnAgregarCliente.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = false;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
