using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EstadoDeCuentas.Logica;
using EstadoDeCuentas.Datos;
using EstadoDeCuentas.Presentacion;

using System.Data.SqlClient;
using System.Data;

 

namespace EstadoDeCuentas.Datos

{
    public class ProductosDatos
    {
        ConexionDatos conn;

        public  ProductosDatos()
        {
           conn = new ConexionDatos();

        }

        public void InsertarProducto(ProductosLogica mos)
        {
            SqlCommand agregar = new SqlCommand($"exec InsertandoProductos {mos.IdCategoria}," +
                $"'{mos.Nombre}','{mos.Color}',{mos.Stock},{mos.Costo},{mos.PrecioVenta}");

            conn.EjecutarSentencia(agregar);
        }
        public void BorrarProducto(ProductosLogica mos)
        {
            SqlCommand borrar = new SqlCommand($"delete Productos where IdProducto={mos.IdProducto}");
            conn.EjecutarSentencia(borrar);
        }
        public void ModificarProducto(ProductosLogica mos)
        {
            SqlCommand modificar = new SqlCommand($" exec ModificandoProductos {mos.IdProducto}, '{mos.IdCategoria}'," +
                $" '{mos.Nombre}','{mos.Color}', {mos.Stock},{mos.Costo},{mos.PrecioVenta}");

            conn.EjecutarSentencia(modificar);
        }

        public DataSet MostrarProductos()
        {
            SqlCommand sqlCommand = new SqlCommand($"select * from Productos "); 
            return  conn.EjecutarSentencia(sqlCommand);

        }
        public DataSet MostrarCategorias(string IdCategoria)
        {
            SqlCommand sqlCommand = new SqlCommand($"select * from Categoria where IdCategoria={IdCategoria}");
            return conn.EjecutarSentencia(sqlCommand);

        }

    }


}
