using FluentNHibernate.Mapping;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Infra.Map
{
    public class ComentarioMap : ClassMap<Comentario>
    {
        public ComentarioMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.Descricao)
                .Not.Nullable()
                .Length(1000);

            Map(x => x.DataCriacao)
                .Not.Nullable();

            References(x => x.Usuario)
                .Not.Nullable();

            HasManyToMany(x => x.Peixes);

            HasMany(x => x.RelatosDePesca);

            HasMany(x => x.TiposLocalDePesca);

            HasManyToMany(x => x.LocaisDePesca);
        }
    }
}
