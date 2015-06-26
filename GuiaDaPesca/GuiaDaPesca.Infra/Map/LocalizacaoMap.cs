using FluentNHibernate.Mapping;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Infra.Map
{
    public class LocalizacaoMap : ClassMap<Localizacao>
    {
        public LocalizacaoMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.Latitude)
                .Not.Nullable();

            Map(x => x.Longitude)
                .Not.Nullable();
        }
    }
}
