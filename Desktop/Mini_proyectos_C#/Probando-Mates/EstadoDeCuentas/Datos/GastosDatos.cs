using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using EstadoDeCuentas.Logica;
using EstadoDeCuentas.Datos;

namespace EstadoDeCuentas.Datos

{
    internal class GastosDatos
    {
        ConexionDatos conn;
        public GastosDatos() 
        { 
            conn = new ConexionDatos();
        }
      
        public void AgregandoGasto(GastosLogica gasto)
        {
            SqlCommand agregando = new SqlCommand($"exec NuevosGastoss '{gasto.IdCategoria}','{gasto.Nombre}','{gasto.Fecha}'," +
                $"{gasto.TotalGasto},{gasto.Cantidad},{gasto.GastoUnidad},'{gasto.Observaciones}'\r\n");
            conn.EjecutarSentencia(agregando);
        }
        public void BorrandoGasto(GastosLogica gasto)
        {
            SqlCommand borrando = new SqlCommand($"delete Gastos where IdGastos={gasto.ID}");
            conn.EjecutarSentencia(borrando);
                
                
        }
        public void ModificandoGasto(GastosLogica gasto)
        {
            SqlCommand mod = new SqlCommand($"exec ModificarGastoss {gasto.ID}," +
                $"'{gasto.IdCategoria}','{gasto.Nombre}','{gasto.Fecha}', {gasto.TotalGasto}," +
                $" {gasto.Cantidad},{gasto.GastoUnidad},'{gasto.Observaciones}'\r\n");
            conn.EjecutarSentencia(mod);


        }


        public DataSet MostrandoGastos()
        {
            SqlCommand gastos = new SqlCommand("select * from Gastos");   

            return conn.EjecutarSentencia(gastos);
        }




        public DataSet MostrandoCategoriaGastos(string dato)
        {
            SqlCommand mos = new SqlCommand($"select * from CategoriaGastos where IdCategoriaGasto={dato}");

                return conn.EjecutarSentencia(mos);

        }

    }
}
