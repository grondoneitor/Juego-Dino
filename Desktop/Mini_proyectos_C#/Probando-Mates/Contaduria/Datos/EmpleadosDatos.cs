using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Contaduria.Presentacion;
using Contaduria.Logic;

namespace Contaduria.Datos
{
    internal class EmpleadosDatos
    {
        ConexionDatos conn;
         public EmpleadosDatos() 
        { 
            conn = new ConexionDatos();

        }
      public bool Agregar(EmpleadosLogic eemp)
        {
        return    conn.Conectar($"\t\t   insert into Empleados(Nombre,PrimerApellido,SegundoApellido,Mail)\r\n\t\t " +
            $"  values('{eemp.Nombre}','{eemp.PrimerApellido}','{eemp.SegundoApellido}','{eemp.Mail}' )");
        }

        public int Borrar(EmpleadosLogic eemp)
        {
             conn.Conectar($"\t\t   delete Empleados where " +
                $"Nombre='{eemp.Nombre}' and PrimerApellido='{eemp.PrimerApellido}' and SegundoApellido='{eemp.SegundoApellido}' and Mail='{eemp.Mail}'");
            return 1;
        }

        public bool Modificar(EmpleadosLogic eemp)
        {
           return conn.Conectar($" update Empleados\r\n\t\t   set Nombre='{eemp.Nombre}', PrimerApellido='{eemp.PrimerApellido}'," +
               $"  SegundoApellido='{eemp.SegundoApellido}',Mail='{eemp.Mail}'\r\n\t\t   where IdEmpleado={eemp.ID} ");
            
        }
      
        public DataSet MostrarEmps()
        {
            SqlCommand sentencia = new SqlCommand("Select * from Empleados");

           return  conn.EjecutarSentencia(sentencia); 
        }

    }
}
