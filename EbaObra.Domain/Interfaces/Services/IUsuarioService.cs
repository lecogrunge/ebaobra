using EbaObra.Domain.Commands.Usuario;
using EbaObra.Domain.Interfaces.Services.Base;

namespace EbaObra.Domain.Interfaces.Services
{
    public interface IUsuarioService : IServiceBase
    {
        CadastrarUsuarioResponse CadastrarUsuario(CadastrarUsuarioRequest request);
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);
    }
}