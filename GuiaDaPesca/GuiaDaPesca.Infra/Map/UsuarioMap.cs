using FluentNHibernate.Mapping;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Infra.Map
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Id(x => x.Id)
                .GeneratedBy.GuidComb();

            Map(x => x.Email)
                .Unique()
                .Not.Nullable()
                .Length(100);

            Map(x => x.Senha)
                .Not.Nullable()
                .Length(100);

            HasMany(x => x.Comentarios);

            HasMany(x => x.LocalisDePesca);
        }
    }
}
