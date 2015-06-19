using GuiaDaPesca.Domain.Model;
using GuiaDePesca.Resourse.Exceptions;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaDaPesca.Infra.Context
{
    public class Inicializar
    {
        protected GuiaDaPescaContext Db = new GuiaDaPescaContext();

        public void IniciarDB()
        {
            using (ISession session = GuiaDaPescaContext.AbrirSessao())
            {
                using (ITransaction tr = session.BeginTransaction())
                {
                    try
                    {
                        Usuario usuario = new Usuario("eduardo.baltazar@hotmail.com", "34erdfcv#$ER", "34erdfcv#$ER");

                        session.Save(usuario);

                        Comentario comentarioRio = new Comentario("Rio", usuario);
                        session.Save(comentarioRio);
                        session.Save(new TipoLocalDePesca(comentarioRio));

                        Comentario comentarioRepresa = new Comentario("Represa", usuario);
                        session.Save(comentarioRepresa);
                        session.Save(new TipoLocalDePesca(comentarioRepresa));

                        Comentario comentarioPesqueiro = new Comentario("Pesqueiro", usuario);
                        session.Save(comentarioPesqueiro);
                        session.Save(new TipoLocalDePesca(comentarioPesqueiro));

                        Comentario comentarioPraia = new Comentario("Praia", usuario);
                        session.Save(comentarioPraia);
                        session.Save(new TipoLocalDePesca(comentarioPraia));

                        Comentario comentarioLoja = new Comentario("Loja", usuario);
                        session.Save(comentarioLoja);
                        session.Save(new TipoLocalDePesca(comentarioLoja));

                        tr.Commit();
                    }
                    catch (Exception ex)
                    {
                        TratarException.NHibernateException(ex, tr);
                    }
                }
            }
        }
    }
}
