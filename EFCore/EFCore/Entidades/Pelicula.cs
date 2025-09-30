namespace EFCore.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool EnCines { get; set; }
        public DateTime FechaStreno { get; set; }
        public HashSet<Comentarios> Comentarios { get; set; } = new HashSet<Comentarios>();
        public HashSet<Genero> Generos { get; set; } = new HashSet<Genero>();
        public HashSet<PeliculaActor> PeliculasActor { get; set; } = new HashSet<PeliculaActor>();
    }
}
