using EstadoDeCuentas.Datos;
using EstadoDeCuentas.Logica;
using System;
using System.Data;
using System.Windows.Forms;


namespace EstadoDeCuentas.Presentacion
{
    public partial class Ordenes : Form
    {
        ConexionDatos cone;
        OrdenesDatos conn;

        public Ordenes()
        {
            cone = new ConexionDatos();
            conn = new OrdenesDatos();
       
            InitializeComponent();
            Mostrar();
            botones();
        }




        //Agregar
        private void button1_Click(object sender, EventArgs e)
        {
            conn.InsertarOrdenes(TomarDatos());
            Mostrar();

        }

        //Borrar
        private void button1_Click_1(object sender, EventArgs e)
        {
            conn.BorrarOrdenes(TomarDatos());
            Mostrar();


        }

        //MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            conn.ModificarOrdenes(TomarDatos());
            Mostrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtIdCliente.Text = null;
            cbxProducto.Text = "";
            cbxColor.Text = "";
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtContactoCliente.Text = "";
            dteFechaCompra.Text = "";
            nudPrecioVenta.Text = "0";
            nudDescuento.Text = "0";
            txtTipodePago.Text = " ";
            txtEstadoPedido.Text = "";
            txtObservaciones.Text = "";
            nmcCantidad.Text = "0";
            


            botones();
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
            ProductosDatos productos = new ProductosDatos();
            DataSet data = productos.MostrarProductos();



            cbxProducto.DataSource = data.Tables[0];
            cbxProducto.DisplayMember = "Nombre";
            cbxProducto.ValueMember = "IdProducto";

            cbxColor.DataSource = data.Tables[0];
            cbxColor.DisplayMember = "Color";
            cbxColor.ValueMember = "Color";

            cbxProducto.Text = "";
            cbxColor.Text = "";
            dteFechaCompra.Text = "";
            nmcCantidad.Text = "";
        }


        private void Mostrar()
        {
            dgvOrdenes.DataSource = conn.MostraOrdenes().Tables[0];

            //    int idClienteSeleccionado = Convert.ToInt32(dgvOrdenes.SelectedRows[0].Cells["IdCliente"].Value);
            //     dgvOrdenesCliente.DataSource = conn.mostrarClientes(idClienteSeleccionado.ToString()).Tables[0];


        }
      /*  private void dgvOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrdenes.SelectedRows.Count > 0)
            {
                int idClienteSeleccionado = Convert.ToInt32(dgvOrdenes.SelectedRows[0].Cells["IdCliente"].Value);

               
                //dgvOrdenesCliente.DataSource = conn.mostrarClientes(idClienteSeleccionado.ToString()).Tables[0];
            }
        }

        */
        public OrdenesLogica TomarDatos()
        {

            OrdenesLogica ordenesLogica = new OrdenesLogica();


            int ID = 0;
            int.TryParse(txtID.Text, out ID);
            ordenesLogica.IdOrden = ID;
            int IDC = 0;
            int.TryParse(txtIdCliente.Text, out IDC);
            ordenesLogica.IdCliente = IDC;
            //        ordenesLogica.NombreProducto = txtNombreProducto.Text;


            ordenesLogica.NombreProducto = cbxProducto.Text;
            ordenesLogica.Color = cbxColor.Text;

            ordenesLogica.NombreCliente = txtNombreCliente.Text;
            ordenesLogica.ApellidoCliente = txtApellidoCliente.Text;
            ordenesLogica.ContactoCliente = txtContactoCliente.Text;

            //         ordenesLogica.FechaCompra = dteFechaCompra.MaxDate;
            ordenesLogica.FechaCompra = DateTime.Parse(dteFechaCompra.Text);

            // MessageBox.Show(ordenesLogica.FechaCompra.ToString());





            int PV = 0;
            int.TryParse(nudPrecioVenta.Text    , out PV);
            ordenesLogica.PrecioVenta = PV;
            MessageBox.Show(PV.ToString());




            int DD = 0;
            int.TryParse(nudDescuento.Text, out DD);
            ordenesLogica.Descuento = DD;

            ordenesLogica.TipoDePago = txtTipodePago.Text;
            ordenesLogica.EstadoDePedido = txtEstadoPedido.Text;
            ordenesLogica.Observaciones = txtObservaciones.Text;


            ordenesLogica.Cantidad = Convert.ToInt32(nmcCantidad.Text);
       

            return ordenesLogica;
        }


        private void Seleccionar(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
            int indiceparaclientes = indice + 1;
            dgvOrdenes.ClearSelection();

 //           nmcCantidad.Maximum = 5000;
 //           nmcCantidad.Minimum = 0;
 //           nudDescuento.Maximum = 100000000;
 //           nudDescuento.Minimum = 0;
//            nudPrecioVenta.Maximum = 100000000;
//            nudPrecioVenta.Minimum = 0;

            string algo = dgvOrdenes.Rows[indice].Cells[2].Value.ToString();

            if (indice >= 0)
            {

                txtID.Text = dgvOrdenes.Rows[indice].Cells[0].Value.ToString();
                txtIdCliente.Text = dgvOrdenes.Rows[indice].Cells[2].Value.ToString();
                dteFechaCompra.Text = dgvOrdenes.Rows[indice].Cells[3].Value.ToString();
                nudPrecioVenta.Text = dgvOrdenes.Rows[indice].Cells[4].Value.ToString();
                nudDescuento.Text = dgvOrdenes.Rows[indice].Cells[5].Value.ToString();
                txtTipodePago.Text = dgvOrdenes.Rows[indice].Cells[6].Value.ToString();
                txtEstadoPedido.Text = dgvOrdenes.Rows[indice].Cells[7].Value.ToString();
                txtObservaciones.Text = dgvOrdenes.Rows[indice].Cells[8].Value.ToString();
                nmcCantidad.Text = dgvOrdenes.Rows[indice].Cells[9].Value.ToString();


                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnBorrar.Enabled = true;
                btnCancelar.Enabled = true;


                int idClienteSeleccionado = 0;

                // Aquí llamas al método de tu clase ConexionBD para obtener el nombre y apellido del cliente
                // ConexionBD conexionBD = new ConexionBD(); // Supongamos que así se crea la instancia de tu clase ConexionBD


                if (dgvOrdenes.Rows[indice].Cells[2].Value.ToString() == "")
                {
                    MessageBox.Show("No se encontro el cliente");

                    idClienteSeleccionado = 0;
                   

                }
                else
                {
                   // MessageBox.Show("No es null" + dgvOrdenes.Rows[indice].Cells[2].Value);
                    idClienteSeleccionado = Convert.ToInt32(dgvOrdenes.Rows[indice].Cells[2].Value);
                    
                }

                DataSet datosCliente = conn.mostrarClientes(idClienteSeleccionado.ToString());


                // Mostrar el nombre y apellido del cliente en los textBox correspondientes
                if (datosCliente != null && datosCliente.Tables.Count > 0 && datosCliente.Tables[0].Rows.Count > 0)
                {
                    txtNombreCliente.Text = datosCliente.Tables[0].Rows[0]["Nombre"].ToString();
                    txtApellidoCliente.Text = datosCliente.Tables[0].Rows[0]["Apellido"].ToString();
                    txtContactoCliente.Text = datosCliente.Tables[0].Rows[0]["Contacto"].ToString();
                }


                
                int idProductoSelecc = 0;
                if (dgvOrdenes.Rows[indice].Cells[1].Value.ToString() == "")
                {
                    idProductoSelecc = 0;
                }
                else
                {
                    idProductoSelecc = Convert.ToInt32(dgvOrdenes.Rows[indice].Cells[1].Value);
                }


                DataSet datosProducto = conn.mostrarProductos(idProductoSelecc.ToString());

                if (datosProducto != null && datosProducto.Tables.Count > 0 && datosProducto.Tables[0].Rows.Count > 0)
                {
                    cbxProducto.Text = datosProducto.Tables[0].Rows[0]["Nombre"].ToString();
                    cbxColor.Text = datosProducto.Tables[0].Rows[0]["Color"].ToString();


                }


            }
        }


        private void botones()
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void nudPrecioVenta_ValueChanged(object sender, EventArgs e)
        {
            nudPrecioVenta.Maximum = 100000000;
            nudPrecioVenta.Minimum = 0;
        }
        private void nudDescuento_ValueChanged(object sender, EventArgs e)
        {
            nudDescuento.Maximum = 100000000;
            nudDescuento.Minimum = 0;
        }
        private void nmcCantidad_ValueChanged(object sender, EventArgs e)
        {
            nmcCantidad.Maximum = 5000;
            nmcCantidad.Minimum = 0;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {


        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


    }
}
