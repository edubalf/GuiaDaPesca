using GuiaDaPesca.Domain.Model;
using GuiaDaPesca.Infra.Context;
using GuiaDaPesca.Infra.Repositories;
using GuiaDePesca.Resourse.Exceptions;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Domain.Interfaces.Repositories
{
    public class TipoLocalDePescaRepository : RepositoryBase<TipoLocalDePesca>, ITipoLocalDePescaRepository
    {
        public List<TipoLocalDePesca> Buscar()
        {
            List<TipoLocalDePesca> retorno = null;
            Comentario comentario = null;
            Usuario usuario = null;

            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                try
                {
                    retorno = session.QueryOver<TipoLocalDePesca>()
                        .JoinAlias(x => x.Comentario, () => comentario)
                        .JoinAlias(x => x.Comentario.Usuario, () => usuario)
                        .List()
                        .ToList();
                }
                catch (Exception ex)
                {
                    TratarException.NHibernateException(ex);
                }
            }

            return retorno;
        }

        public TipoLocalDePesca Obter(Guid id)
        {
            TipoLocalDePesca retorno = null;
            Comentario comentario = null;
            Usuario usuario = null;

            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                try
                {
                    retorno = session.QueryOver<TipoLocalDePesca>()
                        .JoinAlias(x => x.Comentario, () => comentario)
                        .JoinAlias(x => x.Comentario.Usuario, () => usuario)
                        .Where(x => x.Id == id)
                        .List()
                        .FirstOrDefault();
                }
                catch (Exception ex)
                {
                    TratarException.NHibernateException(ex);
                }
            }

            return retorno;
        }
    }
}
