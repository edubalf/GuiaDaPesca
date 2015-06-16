using FluentNHibernate.Mapping;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Infra.Map
{
    public class TipoLocalDePescaMap : ClassMap<TipoLocalDePesca>
    {
        public TipoLocalDePescaMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            References(x => x.Comentario)
                .Not.Nullable();

            HasMany(x => x.LocaisDePesca)
                .LazyLoad();
        }
    }
}
