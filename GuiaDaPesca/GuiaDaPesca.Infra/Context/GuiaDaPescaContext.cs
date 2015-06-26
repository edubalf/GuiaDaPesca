using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using GuiaDaPesca.Infra.Map;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace GuiaDaPesca.Infra.Context
{
    public class GuiaDaPescaContext
    {
        #region Propriedades

        private static ISessionFactory session;

        #endregion

        #region Metodos

        public static ISession AbrirSessao()
        {
            return CriarSessao().OpenSession();
        }

        #endregion

        #region Metodos privados

        private static ISessionFactory CriarSessao()
        {
            if (session != null)
            {
                return session;
            }

            return Fluently.Configure()
                .Database(
                    MsSqlConfiguration
                        .MsSql2012
                        .ConnectionString("Integrated Security=SSPI;Persist Security Info=False;User ID=\"\";Initial Catalog=GuiaDaPescaDB;Data Source=(local);Initial File Name=\"\";")
                        .ShowSql()
                        .FormatSql())
                .Mappings(x =>
                    x.FluentMappings.AddFromAssemblyOf<ComentarioMap>()
                    .AddFromAssemblyOf<LocalDePescaMap>()
                    .AddFromAssemblyOf<LocalizacaoMap>()
                    .AddFromAssemblyOf<PeixeMap>()
                    .AddFromAssemblyOf<TipoLocalDePescaMap>()
                    .AddFromAssemblyOf<UsuarioMap>())
                //.ExposeConfiguration(x => new SchemaExport(x).Create(true, true))
                .BuildSessionFactory();
        }

        #endregion
    }
}
