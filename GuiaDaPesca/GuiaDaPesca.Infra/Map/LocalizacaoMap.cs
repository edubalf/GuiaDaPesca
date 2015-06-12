using GuiaDaPesca.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace GuiaDaPesca.Infra.Map
{
    public class LocalizacaoMap : EntityTypeConfiguration<Localizacao>
    {
        public LocalizacaoMap()
        {
            Property(x => x.Latitude)
                .IsRequired();

            Property(x => x.Longitude)
                .IsRequired();
        }
    }
}
