namespace TiendaJuegos.Datos.Modelos
{
    public class Pago
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoPago { get; set; }  // Ejemplo: "Tarjeta", "Efectivo", "Transferencia"

        // Relación con Juego
        public int JuegoId { get; set; }
        public Juego Juego { get; set; }
    }
}
