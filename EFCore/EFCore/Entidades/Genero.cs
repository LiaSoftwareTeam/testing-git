using System.ComponentModel.DataAnnotations;

namespace EFCore.Entidades
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Nombre { get; set; } = string.Empty;
        public HashSet<Pelicula> Peliculas { get; set; } = new HashSet<Pelicula>();
    }
}
