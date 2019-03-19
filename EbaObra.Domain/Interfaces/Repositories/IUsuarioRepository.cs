using EbaObra.Domain.Entities;
using EbaObra.Domain.Interfaces.IRepositories.Base;

namespace EbaObra.Domain.Interfaces.IRepositories
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        bool VerificarEmailExiste(string email);
    }
}