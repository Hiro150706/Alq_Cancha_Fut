namespace Alq_Cancha_Fa.Models
{
    public class Cancha
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string TipoCancha { get; set; } = string.Empty;
        public int Capacidad { get; set; }
        public double PrecioHora { get; set; }
        public string Estado { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Imagen { get; set; } = string.Empty;
    }
}