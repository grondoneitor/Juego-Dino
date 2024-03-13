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
using EstadoDeCuentas.Presentacion;

namespace EstadoDeCuentas.Presentacion
{
    public partial class Categoria : Form
    {
        CategoriaDato conn;
        public Categoria()
        {
            conn = new CategoriaDato();
            InitializeComponent();
            TomarDatos();
            Mostrar();
            Botones();


        }

        //Agregar Categoria
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conn.InsertandoCategorias(TomarDatos());
            Mostrar();
            Limpiar();
            Botones();

        }

        //Borrar Categoria
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conn.BorrarCategoria(TomarDatos());
            Mostrar();
            Limpiar();
            Botones();

        }

        //Modificar Categoria
        private void btnModificar_Click(object sender, EventArgs e)
        {
            conn.ModificarCategoria(TomarDatos());
            Mostrar();
            Limpiar();
            Botones();
        }

        //Cancelar Accion 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones();
        }

        public void Mostrar()
        {
            dgvCategorias.DataSource = conn.MostrarCategoria().Tables[0];

        }

        // Tomar Datos
        public CategoriaLogica TomarDatos()
        {
            CategoriaLogica logic = new CategoriaLogica();

            int ID = 0;
            int.TryParse(txtID.Text, out ID);
            logic.IdCategoria = ID;

            logic.Categoria = txtCategoria.Text;
            return logic;
        }

        public void Botones()
        {
            btnAgregar.Enabled = true;
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        //Limpiar Entradas
        public void Limpiar()
        {
            txtID.Text = "";
            txtCategoria.Text = "";
        }


        //Seleccionar Datos
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            dgvCategorias.ClearSelection();

            txtID.Text = dgvCategorias.Rows[indice].Cells[0].Value.ToString();
            txtCategoria.Text = dgvCategorias.Rows[indice].Cells[1].Value.ToString();


            btnAgregar.Enabled = false;
            btnBorrar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;

        }
        private void Categoria_Load(object sender, EventArgs e)
        {

        }

    }
}
