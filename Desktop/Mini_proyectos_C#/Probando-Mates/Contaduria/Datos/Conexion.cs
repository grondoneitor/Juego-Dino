using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Contaduria.Datos
{


    internal class ConexionDatos
    {
         private string  conexion = "Data Source=DESKTOP-LVOUQI7;Initial Catalog=db.Sistema;Integrated Security=True";
        SqlConnection conexionConnection;

        public SqlConnection EstableciendoConexion() {
               
         this.conexionConnection = new SqlConnection(this.conexion);
            return this.conexionConnection;  
         
        } 


        public bool Conectar(string strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = this.EstableciendoConexion();
                conexionConnection.Open();
                sqlCommand.ExecuteNonQuery();
               conexionConnection.Close();

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
                comando.Connection = this.EstableciendoConexion();
                sqlDataAdapter.SelectCommand = comando;
                conexionConnection.Open();
                sqlDataAdapter.Fill(DS);
                conexionConnection.Close();
                return DS;

            }
            catch
            {
                return DS;
            }
        }
    }
}
