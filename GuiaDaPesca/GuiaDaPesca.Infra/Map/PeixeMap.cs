using FluentNHibernate.Mapping;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Infra.Map
{
    public class PeixeMap : ClassMap<Peixe>
    {
        public PeixeMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.Nome)
                .Not.Nullable()
                .Length(150);

            HasManyToMany(x => x.Comentarios)
                .LazyLoad();

            HasMany(x => x.PeixesCapturados)
                .LazyLoad();
        }
    }
}
