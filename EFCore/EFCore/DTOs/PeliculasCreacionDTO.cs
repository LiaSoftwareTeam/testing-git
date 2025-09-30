using EFCore.Entidades;

namespace EFCore.DTOs
{
    public class PeliculasCreacionDTO
    {
        public string Nombre { get; set; } = string.Empty;
        public bool EnCines { get; set; }
        public DateTime FechaStreno { get; set; }
        public List<Genero> Generos { get; set; } = new List<Genero>();
        public List<PeliculaActorCreacionDTO> PeliculasActores { get; set; } = new List<PeliculaActorCreacionDTO>();
    }
}
