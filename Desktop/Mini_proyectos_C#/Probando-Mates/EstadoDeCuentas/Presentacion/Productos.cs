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
    public partial class Productos : Form
    {
        ProductosDatos conn;
        public Productos()
        {
            conn = new ProductosDatos();

            InitializeComponent();
            Mostrar();
            Botones();

        }
        //Agregar Producto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conn.InsertarProducto(mos());
            Mostrar();
            Limpiar();
            Botones();
        }

        //Borrar Producto
        private void button1_Click(object sender, EventArgs e)
        {
            conn.BorrarProducto(mos());
            Mostrar();
            Limpiar();
            Botones();
        }

        //Modificar Producto
        private void btnModificar_Click(object sender, EventArgs e)
        {
            conn.ModificarProducto(mos());
            Mostrar();
            Limpiar();
            Botones();

        }

        //Cancelamos Accion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Botones();
        }



        //Muestra datos en tabla
        private void Mostrar()
        {
            dgvProductos.DataSource = conn.MostrarProductos().Tables[0];

        }

        //Tomar Datos
        public ProductosLogica mos()
        {
            ProductosLogica productosLogica = new ProductosLogica();


            int ID = 0;
            int.TryParse(txtID.Text, out ID);
            productosLogica.IdProducto = ID;

            productosLogica.IdCategoria = cbxCategoria.Text ;

            MessageBox.Show(txtProducto.Text);
            productosLogica.Nombre = txtProducto.Text;
            productosLogica.Color = txtColor.Text;

            nudStock.Maximum = 10000;
            nudStock.Minimum = 0;
            productosLogica.Stock = Convert.ToInt32(nudStock.Text);

            nudCosto.Maximum = 10000000;
            nudCosto.Minimum = 0;
            int Costo = 0;
            int.TryParse(nudCosto.Text, out Costo);
            productosLogica.Costo = Costo;

            nudPrecioVenta.Maximum = 10000000;
            nudPrecioVenta.Minimum = 0;
            int PrecioVenta = 0;
            int.TryParse(nudPrecioVenta.Text, out PrecioVenta);
            productosLogica.PrecioVenta = PrecioVenta;


            return productosLogica;
        }


        //Seleccionamos los valores
        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            dgvProductos.ClearSelection();



            txtID.Text = dgvProductos.Rows[indice].Cells[0].Value.ToString();
         //  cbxCategoria.Text = dgvProductos.Rows[indice].Cells[1].Value.ToString();
            txtProducto.Text= dgvProductos.Rows[indice].Cells[2].Value.ToString();    
            txtColor.Text= dgvProductos.Rows[indice].Cells[3].Value.ToString();
            nudStock.Text= dgvProductos.Rows[indice].Cells[4].Value.ToString();
            nudCosto.Text = dgvProductos.Rows[indice].Cells[5].Value.ToString();
            nudPrecioVenta.Text = dgvProductos.Rows[indice].Cells[6].Value.ToString();
            



            int IdCategoriaSelecc = Convert.ToInt32(dgvProductos.Rows[indice].Cells[1].Value);

            DataSet data = conn.MostrarCategorias(IdCategoriaSelecc.ToString());

            if (data != null && data.Tables.Count > 0 && data.Tables[0].Rows.Count > 0)
            {
                cbxCategoria.Text = data.Tables[0].Rows[0]["Nombre"].ToString();
            }


            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            btnCancelar.Enabled = true;

        }

        public void Botones()
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = false;    
        }

        public void Limpiar()
        {
            txtID.Text = "";
            //  cbxCategoria.Text = dgvProductos.Rows[indice].Cells[1].Value.ToString();
            txtProducto.Text = "";
            txtColor.Text = "";
            nudStock.Text = "0";
            nudCosto.Text = "0";
            nudPrecioVenta.Text = "0";
            cbxCategoria.Text = "";
        }

        //Llenamos Combo Box
        private void Productos_Load(object sender, EventArgs e)
        {
            CategoriaDato categoriaDato = new CategoriaDato();
            DataSet data = categoriaDato.MostrarCategoria();


            cbxCategoria.DataSource= data.Tables[0];
            cbxCategoria.DisplayMember = "Nombre";
            cbxCategoria.ValueMember = "IdCategoria";

            cbxCategoria.Text = "";

        }
        private void nudCosto_ValueChanged(object sender, EventArgs e)
        {
            nudCosto.Maximum = 10000000;
            nudCosto.Minimum = 0;

        }
        private void nudPrecioVenta_ValueChanged(object sender, EventArgs e)
        {
            nudPrecioVenta.Maximum = 10000000;
            nudPrecioVenta.Minimum = 0;
        }
        private void nudStock_ValueChanged(object sender, EventArgs e)
        {
            nudStock.Maximum = 10000;
            nudStock.Minimum = 0;   
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
