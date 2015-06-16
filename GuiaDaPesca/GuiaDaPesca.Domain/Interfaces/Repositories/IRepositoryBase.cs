using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void AdicionarPadrao(TEntity obj);
        TEntity ObterPadrao(Guid id);
        List<TEntity> BuscarPadrao();
        void AtualizarPadrao(TEntity obj);
        void RemoverPadrao(TEntity obj);
    }
}
