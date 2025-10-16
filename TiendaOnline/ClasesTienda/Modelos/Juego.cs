namespace TiendaJuegos.Datos.Modelos
{
    public class Juego
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        // Relación con Pago
        public ICollection<Pago> Pagos { get; set; }
    }
}