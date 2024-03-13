using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using EstadoDeCuentas.Logica;
using EstadoDeCuentas.Presentacion;


namespace EstadoDeCuentas.Datos
{

    internal class IngresosDatos
    {
        ConexionDatos conn; 
        public IngresosDatos()
        {
            conn = new ConexionDatos(); 

        }


        public DataSet ingresosBrutos()
        {
            SqlCommand cmd = new SqlCommand("select SUM(Plata) from Ingresos ");

            return conn.EjecutarSentencia(cmd);
        }

        public DataSet mostrarIngresos()
        {
            SqlCommand ingresos = new SqlCommand("select * from Ingresos");

            return conn.EjecutarSentencia(ingresos);

        } 
    }
}
