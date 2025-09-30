using EFCore.Entidades;

namespace EFCore.DTOs
{
    public class ActorCreacionDTO
    {
        public string Nombre { get; set; } = string.Empty;
        public decimal Fortuna { get; set; }
        public DateTime Nacimiento { get; set; }
    }
}
