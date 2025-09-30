using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCore.Entidades.Configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(x => x.Nombre).HasMaxLength(150);
            builder.Property(x => x.Nacimiento).HasColumnType("date");
            builder.Property(x => x.Fortuna).HasPrecision(18, 2);
        }
    }
}
