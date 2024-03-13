using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Contaduria.Logic;
using Contaduria.Presentacion;

namespace Contaduria.Datos
{ 
      public class DepartamentoDatos  
      {
        ConexionDatos conn;
        public  DepartamentoDatos()
        {
            conn = new ConexionDatos();
            
        }
        
        public bool Agregarr(DepartamentoLogic depa) 
        {
            return conn.Conectar($"INSERT INTO Departamentos" +
            $" ( Departamento)\r\nVALUES\r\n('{depa.Departamento}')");



        }

        public int Borrarr(DepartamentoLogic departamentoLogic)
        {
            conn.Conectar($"Delete Departamentos where IdDepartamento='{departamentoLogic.ID}'\r\n");
            return 1;

        }
        public int Modificar(DepartamentoLogic departamentoLogic)
        {
            conn.Conectar($"\t\t   update Departamentos\r\n\t\t   set Departamento='{departamentoLogic.Departamento}'\r\n\t\t   where IdDepartamento= {departamentoLogic.ID}");
            return 1;

        }


        public DataSet MostrarDepa()
        {
            SqlCommand sentencia = new SqlCommand("select * from Departamentos");

            return conn.EjecutarSentencia(sentencia);   
          }

    }
}
