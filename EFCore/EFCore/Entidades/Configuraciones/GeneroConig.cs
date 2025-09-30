using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Entidades.Configuraciones
{
    public class GeneroConig : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x => x.Nombre).HasMaxLength(150);
        }
    }
}
