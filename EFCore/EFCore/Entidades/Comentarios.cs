namespace EFCore.Entidades
{
    public class Comentarios
    {
        public int Id { get; set; }
        public string? Contenido { get; set; }
        public bool Recomendar { get; set; }
        public int PeliculaID { get; set; }
        public Pelicula Pelicula { get; set; } = null!;
    }
}
