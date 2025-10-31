using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda.modelo
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string NombreEmpresa { get; set; }
        public string Email { get; set; }

        public ICollection<Producto> Productos { get; set; } // contiene depemdencias para navegar a la clase
    }
}
