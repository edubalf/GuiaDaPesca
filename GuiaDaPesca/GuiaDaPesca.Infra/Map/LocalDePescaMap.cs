using GuiaDaPesca.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace GuiaDaPesca.Infra.Map
{
    public class LocalDePescaMap : EntityTypeConfiguration<LocalDePesca>
    {
        public LocalDePescaMap()
        {
            Property(x => x.Nome)
                .HasMaxLength(200)
                .IsRequired();

            Property(x => x.Aprovado)
                .IsRequired();

            HasRequired(x => x.Localizacao);

            HasRequired(x => x.UsuarioCadastro);

            HasRequired(x => x.TipoLocalDePesca);
        }
    }
}
