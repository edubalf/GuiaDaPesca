using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Infra.Map;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace GuiaDaPesca.Infra.Context
{
    public class GuiaDaPescaContext : DbContext
    {
        #region Propriets

        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<LocalDePesca> LocaisDePesca { get; set; }
        public DbSet<Localizacao> Localizacoes { get; set; }
        public DbSet<Peixe> Peixes { get; set; }
        public DbSet<PeixeCapturado> PeixesCapturados { get; set; }
        public DbSet<RelatoDePesca> RelatosDePesca { get; set; }
        public DbSet<TipoLocalDePesca> TiposLocalDePesca { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        #endregion

        #region Constructor

        public GuiaDaPescaContext()
            : base("GuiaDaPescaDB")
        {

        }

        #endregion

        #region Methods

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder = MontarMaps(modelBuilder);
        }

        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;
        //        }

        //        if (entry.State == EntityState.Modified)
        //        {
        //            entry.Property("DataCadastro").IsModified = false;
        //        }
        //    }

        //    return base.SaveChanges();
        //}

        #endregion

        #region Private Methods

        private DbModelBuilder MontarMaps(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ComentarioMap());
            modelBuilder.Configurations.Add(new LocalDePescaMap());
            modelBuilder.Configurations.Add(new LocalizacaoMap());
            modelBuilder.Configurations.Add(new PeixeCapturadoMap());
            modelBuilder.Configurations.Add(new PeixeMap());
            modelBuilder.Configurations.Add(new RelatoDePescaMap());
            modelBuilder.Configurations.Add(new TipoLocalDePescaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());

            return modelBuilder;
        }

        #endregion
    }
}
