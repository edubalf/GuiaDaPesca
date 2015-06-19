using FluentNHibernate.Mapping;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Infra.Map
{
    public class RelatoDePescaMap : ClassMap<RelatoDePesca>
    {
        public RelatoDePescaMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.Data)
                .Nullable();

            References(x => x.Comentario)
                .Not.Nullable()
                .Cascade.SaveUpdate();

            HasManyToMany(x => x.PeixesCapturados);

            HasManyToMany(x => x.LocaisDePesca);
        }
    }
}
