using GuiaDaPesca.Domain.Interfaces.Repositories;
using GuiaDaPesca.Infra.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GuiaDaPesca.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected GuiaDaPescaContext Db = new GuiaDaPescaContext();

        public void Adicionar(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity Obter(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Buscar()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Atualizar(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remover(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
