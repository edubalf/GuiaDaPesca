using FluentNHibernate.Mapping;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Infra.Map
{
    public class PeixeCapturadoMap : ClassMap<PeixeCapturado>
    {
        public PeixeCapturadoMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.Peso)
                .Nullable();

            Map(x => x.Tamanho)
                .Nullable();

            References(x => x.Peixe);

            HasManyToMany(x => x.RelatosDePesca);
        }
    }
}
