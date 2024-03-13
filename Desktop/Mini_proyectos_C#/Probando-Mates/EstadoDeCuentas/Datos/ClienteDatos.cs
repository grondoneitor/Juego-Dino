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
    internal class ClienteDatos
    {
        ConexionDatos conn;
   public ClienteDatos()
        {
            conn = new ConexionDatos();
        } 

        public DataSet Agregar(ClienteLogica clienteLogica)
        {
            SqlCommand sqlCommand = new SqlCommand("  " +
                " insert into Cliente(Nombre,Apellido,Contacto)\r\n  " +
                $" values ('{clienteLogica.NombreCliente}','{clienteLogica.ApellidoCliente}'," +
                $"'{clienteLogica.Contacto}')\r\n");

               return conn.EjecutarSentencia(sqlCommand);
           
        }
        public DataSet Borrar(ClienteLogica clienteLogica)
        {
            SqlCommand sqlCommand = new SqlCommand($"exec Boliente  {clienteLogica.IdCliente} ");

            return conn.EjecutarSentencia(sqlCommand);

        }
        public DataSet Modificar(ClienteLogica clienteLogica)
        {
            SqlCommand sqlCommand = new SqlCommand($"update Cliente\r\nset Nombre='{clienteLogica.NombreCliente}'," +
                                                  $"  Apellido='{clienteLogica.ApellidoCliente}'," +
                                                  $"Contacto='{clienteLogica.Contacto}'\r\nwhere IdCliente={clienteLogica.IdCliente}");

            return conn.EjecutarSentencia(sqlCommand);

        }

        public DataSet MostrarCliente( )
        {
            SqlCommand mostrarCLientes = new SqlCommand("select * from Cliente");

            return  conn.EjecutarSentencia(mostrarCLientes);
        }


    }
}
