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
using System.Collections.ObjectModel;


namespace Probando_Mates2
{
    public partial class Form1 : Form
    {


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LVOUQI7;Initial Catalog=PruebaMates;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
