using GuiaDaPesca.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace GuiaDaPesca.Infra.Map
{
    public class RelatoDePescaMap : EntityTypeConfiguration<RelatoDePesca>
    {
        public RelatoDePescaMap()
        {
            HasRequired(x => x.Comentario);
        }
    }
}
