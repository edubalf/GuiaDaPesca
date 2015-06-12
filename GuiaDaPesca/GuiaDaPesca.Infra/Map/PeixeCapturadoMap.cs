using GuiaDaPesca.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace GuiaDaPesca.Infra.Map
{
    public class PeixeCapturadoMap : EntityTypeConfiguration<PeixeCapturado>
    {
        public PeixeCapturadoMap()
        {
            HasRequired(x => x.Peixe);
        }
    }
}
