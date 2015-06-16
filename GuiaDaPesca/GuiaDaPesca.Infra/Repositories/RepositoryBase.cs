using GuiaDaPesca.Domain.Interfaces.Repositories;
using GuiaDaPesca.Infra.Context;
using GuiaDePesca.Resourse.Exceptions;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected GuiaDaPescaContext Db = new GuiaDaPescaContext();

        public void AdicionarPadrao(TEntity obj)
        {
            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                using (ITransaction tr = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(obj);
                        tr.Commit();
                    }
                    catch (Exception ex)
                    {
                        TratarException.NHibernateException(ex, tr);
                    }
                }
            }
        }

        public void AtualizarPadrao(TEntity obj)
        {
            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                using (ITransaction tr = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(obj);
                        tr.Commit();
                    }
                    catch (Exception ex)
                    {
                        TratarException.NHibernateException(ex, tr);
                    }
                }
            }
        }

        public void RemoverPadrao(TEntity obj)
        {
            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                using (ITransaction tr = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(obj);
                        tr.Commit();
                    }
                    catch (Exception ex)
                    {
                        TratarException.NHibernateException(ex, tr);
                    }
                }
            }
        }

        public TEntity ObterPadrao(Guid id)
        {
            TEntity retorno = null;

            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                try
                {
                    retorno = session.Get<TEntity>(id);
                }
                catch (Exception ex)
                {
                    TratarException.NHibernateException(ex);
                }
            }

            return retorno;
        }

        public List<TEntity> BuscarPadrao()
        {
            List<TEntity> retorno = null;

            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                try
                {
                    retorno = session.Query<TEntity>().ToList();
                }
                catch (Exception ex)
                {
                    TratarException.NHibernateException(ex);
                }
            }

            return retorno;
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
