using EbaObra.Domain.Commands.Usuario;
using EbaObra.Domain.Entities;
using EbaObra.Domain.Interfaces.IRepositories;
using EbaObra.Domain.Interfaces.Services;
using EbaObra.Domain.ValueObjects;
using Flunt.Notifications;

namespace EbaObra.Domain.Services
{
    public sealed class UsuarioService : Notifiable, IUsuarioService
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
            // Fail fast validation
            request.Validate();
            if (request.Invalid)
            {
                AddNotifications(request);
                return new CadastrarUsuarioResponse() { Success = false, Message = "Não foi possível cadastrar o usuário." };
            }

            // Verificar se o e-mail já está cadastrado
            if (_repository.VerificarEmailExiste(request.Email))
                AddNotification("Email", "Este e-mail já está em uso.");

            // Gerar os VOs
            Nome nome = new Nome(request.Nome, request.Sobrenome);
            Email email = new Email(request.Email);            

            // Gerar entidades
            Usuario usuario = new Usuario(nome, email, request.Senha, request.TipoUsuario);

            // Agrupar validações
            AddNotifications(nome, email);

            if (Invalid)
                return new CadastrarUsuarioResponse() { Success = false, Message = "Não foi possível cadastrar o usuário." };

            // Salvar dados
            _repository.Create(usuario);

            // Enviar email de confirmação de cadastro
            _emailService.Send(nome.PrimeiroNome, email.EnderecoEmail, "Bem vindo", "Seu cadastro está quase concluído");

            // Retornar informações
            return new CadastrarUsuarioResponse() { Success = true, Message = "Cadastro realizado com sucesso" };
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}