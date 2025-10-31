using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda.modelo
{
    public class Cliente : Persona
    {
        public int id { get; set; }
        public string Direccion { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }


    }
}
