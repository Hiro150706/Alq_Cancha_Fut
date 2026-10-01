namespace Alq_Cancha_Fa.Models
{
    public class Horario
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Fecha { get; set; } = string.Empty;
        public string Hora { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public bool Disponibilidad { get; set; }
        public string TipoCancha { get; set; } = string.Empty;
        public double Precio { get; set; }
        public int Duracion { get; set; }
    }
}