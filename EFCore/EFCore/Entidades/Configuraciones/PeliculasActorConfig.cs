using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Entidades.Configuraciones
{
    public class PeliculasActorConfig : IEntityTypeConfiguration<PeliculasActor>
    {
        public void Configure(EntityTypeBuilder<PeliculasActor> builder)
        {
            builder.HasKey(pa => new { pa.PeliculaID, pa.AutorID });
        }
    }
}
