namespace EFCore.Entidades
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Fortuna { get; set; }
        public DateTime Nacimiento { get; set; }
        public List<PeliculasActor> PeliculasActores { get; set; } = new List<PeliculasActor>();
    }
}
