using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasesTienda.modelo
{
    public class Envio
    {
       public int Id { get; set; }
       public int IdPedido { get; set; }
       public Pedido Pedido { get; set; }
       public int DireccionEntrega { get; set; }
    
    }
}
