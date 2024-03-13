using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstadoDeCuentas.Logica
{
    public class OrdenesLogica
    {
        public int IdOrden { get; set; }
        public int IdCliente { get; set; }
        public string NombreProducto { get; set; }
        public string Color { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string ContactoCliente { get; set; }
        public DateTime FechaCompra { get; set; }
        public int PrecioVenta { get; set; }
        public int Descuento { get; set; }
        public string EstadoDePedido { get; set; }
        public string TipoDePago { get; set; }
        public string Observaciones { get; set; }
        public int Cantidad {get; set; }



    }
}
