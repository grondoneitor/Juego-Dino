using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;


namespace EstadoDeCuentas.Datos
{
    internal class ConexionDatos
    {
        private string conexion = "Data Source=DESKTOP-LVOUQI7;Initial Catalog=PruebaMates;Integrated Security=True";

        SqlConnection SQLConection;

        private SqlConnection Conectando()
        {
            this.SQLConection = new SqlConnection(this.conexion);
            return this.SQLConection;

        }


        public bool IniciandoConexion(string strComando)
        {
            try
            {   
                 SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.Conectando();
                this.SQLConection.Open();
                sqlCommand.ExecuteNonQuery();
                this.SQLConection.Close();


                return true;

            }
            catch
            {
                return false;   
            }
        }

        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                SqlCommand comando = new SqlCommand();
                comando = sqlComando;
                comando.Connection = this.Conectando();
                sqlDataAdapter.SelectCommand = comando;
                SQLConection.Open();
                sqlDataAdapter.Fill(DS);
                SQLConection.Close();
                return DS;

            }
            catch
            {
                return DS;
            }
        }



    }
}
