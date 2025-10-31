using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClasesTienda.modelo
{
    public class Producto
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
       public string Tipo { get; set; }
       public decimal Precio { get; set; }
       public int Stock { get; set; }
       public string ClaveDigital { get; set; }
       public int IdProveedor { get; set; } // FK de la clase correspondiente 
        public Proveedor Proveedor { get; set; } //referencia de navegacion a la clase
        public List<PedidoProducto> PedidoProductos { get; set; }


    }
}
