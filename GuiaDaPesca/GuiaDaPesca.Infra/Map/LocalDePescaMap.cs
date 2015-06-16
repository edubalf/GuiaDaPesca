using FluentNHibernate.Mapping;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Infra.Map
{
    public class LocalDePescaMap : ClassMap<LocalDePesca>
    {
        public LocalDePescaMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.Aprovado)
                .Not.Nullable();

            Map(x => x.Nome)
                .Not.Nullable()
                .Length(100);

            References(x => x.Localizacao)
                .Not.Nullable()
                .LazyLoad();

            References(x => x.UsuarioCadastro)
                .Not.Nullable()
                .LazyLoad();

            References(x => x.TipoLocalDePesca)
                .Not.Nullable()
                .LazyLoad();

            HasManyToMany(x => x.Comentarios)
                .LazyLoad();

            HasManyToMany(x => x.RelatosDePesca)
                .LazyLoad();
        }
    }
}
