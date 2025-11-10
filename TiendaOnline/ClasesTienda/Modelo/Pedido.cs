using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda.modelo
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Fecha { get; set; }
        public string TipoProducto { get; set; }
        public int PrecioTotal { get; set; }
        public int Cantidad { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public int IdFormaPago { get; set; }
        public FormaPago FormaPago { get; set; }
        public List<PedidoProducto> PedidoProductos { get; set; }
    }
}
