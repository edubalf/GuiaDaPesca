using System;
using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Infra.Repositories;
using System.Linq;
using GuiaDePesca.Resourse.Validation;
using NHibernate;
using GuiaDaPesca.Infra.Context;
using GuiaDePesca.Resourse.Exceptions;
using NHibernate.Linq;

namespace GuiaDaPesca.Domain.Interfaces.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public void Adicionar(Usuario usuario)
        {
            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                using (ITransaction tr = session.BeginTransaction())
                {
                    try
                    {
                        Assertion.Null(session.Query<Usuario>().Where(x => x.Email == usuario.Email).FirstOrDefault(), "O Email já existe.");

                        session.Save(usuario);
                        tr.Commit();
                    }
                    catch (Exception ex)
                    {
                        TratarException.NHibernateException(ex, tr);
                    }
                }
            }
        }

        public Usuario Obter(string email)
        {
            Usuario retorno = null;

            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                retorno = session.Query<Usuario>().Where(x => x.Email == email).FirstOrDefault();
            }

            return retorno;
        }
    }
}
