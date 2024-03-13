using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contaduria.Logic
{
    internal class EmpleadosLogic
    {
        public int ID { get; set; } 
        public string Nombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public string Mail { get; set; } 
        
        public int Departamento { get; set; }

        public byte[] Foto { get; set; }

    }
}
