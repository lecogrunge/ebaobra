using EbaObra.Domain.Entities;
using EbaObra.Domain.Interfaces.IRepositories;
using EbaObra.Infra.Persistence.EF;
using EbaObra.Infra.Persistence.Repositories.Base;
using System.Linq;

namespace EbaObra.Infra.Persistence.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context dbContext) : base(dbContext)
        {

        }

        public bool VerificarEmailExiste(string email)
        {
            return dbContext.Usuarios.Any(s => s.Email.EnderecoEmail.Equals(email));
        }
    }
}