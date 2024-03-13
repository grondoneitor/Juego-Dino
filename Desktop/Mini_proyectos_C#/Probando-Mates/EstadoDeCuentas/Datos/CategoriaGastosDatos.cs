using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using EstadoDeCuentas.Logica;


namespace EstadoDeCuentas.Datos
{
    internal class CategoriaGastosDatos
    {

        ConexionDatos conn;
        public CategoriaGastosDatos() 
        { 
         conn = new ConexionDatos();    

        }


        public DataSet MostrarCategorias()
        {
            SqlCommand cat = new SqlCommand("select * from CategoriaGastos");

         return   conn.EjecutarSentencia(cat);

        }

    }

}
