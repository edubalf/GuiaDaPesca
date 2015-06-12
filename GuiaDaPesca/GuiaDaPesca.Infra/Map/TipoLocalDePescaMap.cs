using GuiaDaPesca.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDaPesca.Infra.Map
{
    public class TipoLocalDePescaMap : EntityTypeConfiguration<TipoLocalDePesca>
    {
        public TipoLocalDePescaMap()
        {
            HasRequired(x => x.Comentario);
        }
    }
}
