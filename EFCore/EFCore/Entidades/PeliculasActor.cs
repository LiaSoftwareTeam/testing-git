namespace EFCore.Entidades
{
    public class PeliculasActor
    {
        public int PeliculaID { get; set; }
        public Pelicula Pelicula { get; set; } = null!;
        public int AutorID { get; set; }
        public Actor Actor { get; set; } = null!;
        public string Personaje { get; set; } = string.Empty;
        public int Orden { get; set; }
        public List<PeliculasActor> PeliculasActores { get; set; } = new List<PeliculasActor>();
    }
}
