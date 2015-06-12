using GuiaDaPesca.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace GuiaDaPesca.Infra.Map
{
    public class ComentarioMap : EntityTypeConfiguration<Comentario>
    {
        public ComentarioMap()
        {
            Property(x => x.Descricao)
                .HasMaxLength(1000)
                .IsRequired();

            Property(x => x.DataCriacao)
                .IsRequired();

            HasRequired(x => x.Usuario);
        }
    }
}
