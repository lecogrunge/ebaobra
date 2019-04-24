using EbaObra.Domain.Commands.Usuario;
using EbaObra.Domain.Entities;
using EbaObra.Domain.Interfaces.IRepositories;
using EbaObra.Domain.Interfaces.Services;
using EbaObra.Domain.ValueObjects;

namespace EbaObra.Domain.Services
{
	public sealed class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        private readonly IEmailService _emailService;

        public UsuarioService(IUsuarioRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {

            throw new System.NotImplementedException();
        }

        public CadastrarUsuarioResponse CadastrarUsuario(CadastrarUsuarioRequest request)
        {
			return new CadastrarUsuarioResponse();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}