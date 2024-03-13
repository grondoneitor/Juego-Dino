using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoDeCuentas.Logica
{
    public class GastosLogica
    {
        public int ID { get; set; }
        public string IdCategoria { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int TotalGasto { get; set; }
        public int Cantidad { get; set; }
        public int GastoUnidad { get; set; }
        public string Observaciones { get; set; } 

    }
}
