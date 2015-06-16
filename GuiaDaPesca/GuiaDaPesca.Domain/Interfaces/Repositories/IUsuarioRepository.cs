using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        void Adicionar(Usuario usuario);

        Usuario Obter(string email);
    }
}
