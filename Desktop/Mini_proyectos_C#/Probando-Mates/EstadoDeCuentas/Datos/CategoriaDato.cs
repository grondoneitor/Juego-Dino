using EstadoDeCuentas.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoDeCuentas.Datos
{
  public class CategoriaDato
  {

        ConexionDatos conn;
        public CategoriaDato()
        {
            conn = new ConexionDatos();
        }

        public void InsertandoCategorias(CategoriaLogica mos)
        {
            SqlCommand insert = new SqlCommand($"insert into Categoria(Nombre)\r\nvalues ('{mos.Categoria}')");
            conn.EjecutarSentencia(insert);
        
        }
        public void BorrarCategoria(CategoriaLogica mos)
        {
            SqlCommand borrar = new SqlCommand($"delete Categoria where IdCategoria={mos.IdCategoria}");
            conn.EjecutarSentencia(borrar);
        }
        public void ModificarCategoria(CategoriaLogica mos)
        {
            SqlCommand modificar = new SqlCommand($"update Categoria\r\nset Nombre='{mos.Categoria}'\r\n" +
                $"where IdCategoria={mos.IdCategoria}");
            conn.EjecutarSentencia(modificar);
        }

        public DataSet MostrarCategoria()
        {
            SqlCommand mostrar = new SqlCommand("select * from Categoria");
            return conn.EjecutarSentencia(mostrar);
        }
  }
}
