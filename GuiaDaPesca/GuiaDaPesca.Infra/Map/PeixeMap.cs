using GuiaDaPesca.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDaPesca.Infra.Map
{
    public class PeixeMap : EntityTypeConfiguration<Peixe>
    {
        public PeixeMap()
        {
            Property(x => x.Nome)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
