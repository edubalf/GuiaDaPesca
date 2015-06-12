using GuiaDaPesca.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDaPesca.Infra.Map
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            Property(x => x.Login)
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.Senha)
                .IsFixedLength()
                .HasMaxLength(32)
                .IsRequired();
        }
    }
}
