using EFCore.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCore
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder) //darle un length de 150 a todos los strings
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }
        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Actor> Actores => Set<Actor>();
        public DbSet<Pelicula> Pelicula => Set<Pelicula>();
        public DbSet<Comentarios> Comentarios => Set<Comentarios>();
        public DbSet<PeliculasActor> PeliculasActores => Set<PeliculasActor>();
    }
}
