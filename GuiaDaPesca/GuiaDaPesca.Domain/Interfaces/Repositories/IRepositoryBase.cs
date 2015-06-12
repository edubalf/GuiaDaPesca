using System.Collections.Generic;

namespace GuiaDaPesca.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity Obter(int id);
        IEnumerable<TEntity> Buscar();
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
    }
}
