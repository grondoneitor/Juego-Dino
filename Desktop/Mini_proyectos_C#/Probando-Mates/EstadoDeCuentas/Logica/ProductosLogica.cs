using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoDeCuentas.Logica
{
    public  class ProductosLogica
    {

        public int IdProducto { get; set; }
        public string IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }
        public int Costo { get; set; }
        public int PrecioVenta { get; set; }
    }
}
