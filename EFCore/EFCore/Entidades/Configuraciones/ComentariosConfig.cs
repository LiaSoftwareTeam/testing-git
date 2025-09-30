using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Entidades.Configuraciones
{
    public class ComentariosConfig : IEntityTypeConfiguration<Comentarios>
    {
        public void Configure(EntityTypeBuilder<Comentarios> builder)
        {

        }
    }
}
