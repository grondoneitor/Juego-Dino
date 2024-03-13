using System.Data.SqlClient;
using System.Data;
namespace Probando_Mates
{
    public partial class Form1 : Form
    {

        SqlConnection conection = new SqlConnection(@"Data Source=DESKTOP-LVOUQI7;Initial Catalog=PruebaMates;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresandoDatot();
        }

        private void IngresandoDatot()
        {
            SqlDataAdapter data = new SqlDataAdapter("Select * from Cliente", conection);
            DataTable dt = new DataTable();
            data.Fill(dt);
            this.dataGridView1.DataSource = dt;

        }




    }
}