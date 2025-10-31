using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTienda.modelo
{
     public class Empleado : Persona
    {
        public int Id { get; set; }
        public string Cargo { get; set; }
        public int Sueldo { get; set; }
    }
}
