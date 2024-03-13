using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

using EstadoDeCuentas.Datos;
using EstadoDeCuentas.Presentacion;
using EstadoDeCuentas.Logica;

namespace EstadoDeCuentas.Datos
{

    internal class OrdenesDatos
    {

        ConexionDatos conn;
        public OrdenesDatos()
        {

            conn = new ConexionDatos();
        }

        public void InsertarOrdenes(OrdenesLogica orden)
        {
            SqlCommand insert = new SqlCommand($"   exec IngresarVentaa '{orden.NombreProducto}','{orden.Color}','{orden.NombreCliente}'," +
                $"'{orden.ApellidoCliente}', '{orden.ContactoCliente}' , '{orden.FechaCompra}',{orden.PrecioVenta}, " +
                $"{orden.Descuento}, '{orden.TipoDePago}', {orden.EstadoDePedido}, '{orden.Observaciones}'," +
                $"{orden.Cantidad}\r\n");
      
            conn.EjecutarSentencia( insert ); 
        
        }

        public void ModificarOrdenes(OrdenesLogica orden)
        {
            SqlCommand modificar = new SqlCommand("" +
            $"exec ModificarOrden {orden.IdOrden},{orden.IdCliente},'{orden.NombreProducto}'," +
            $"'{orden.Color}','{orden.NombreCliente}'," +
            $"'{orden.ApellidoCliente}', '{orden.ContactoCliente}' ,'{orden.FechaCompra}', {orden.PrecioVenta}," +
            $" {orden.Descuento},'{orden.TipoDePago}', {orden.EstadoDePedido}, '{orden.Observaciones}',{orden.Cantidad}\r\n");

            conn.EjecutarSentencia(modificar);
        }

        public void BorrarOrdenes(OrdenesLogica orden)
        {
            SqlCommand borrar = new SqlCommand($"  exec BorrarOrdenes {orden.IdOrden}");

            conn.EjecutarSentencia(borrar);
        }


        public DataSet mostrarClientes(string IdCliente)
        {
            SqlCommand cli = new SqlCommand($"select Nombre, Apellido, Contacto from Cliente where IdCliente = {IdCliente}");
            return conn.EjecutarSentencia(cli);
        }
        public DataSet mostrarProductos(string IdProducto)
        {
            SqlCommand cli = new SqlCommand($" select Nombre, Color from Productos where IdProducto ={IdProducto}");
            return conn.EjecutarSentencia(cli);
        }


        public DataSet MostraOrdenes()
        {
            SqlCommand comando = new SqlCommand("select * from Ordenes ");

            return conn.EjecutarSentencia(comando);
        }


    }
}
