using EbaObra.Domain.Enum;
using EbaObra.Domain.ValueObjects;
using EbaObra.Shared.Commands;
using Flunt.Notifications;

namespace EbaObra.Domain.Commands.Usuario
{
    public class CadastrarUsuarioRequest : Notifiable, ICommand
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }        
        public EnumStatusUsuario Status { get; set; }
        public EnumTipoUsuario TipoUsuario { get; set; }

        public void Validate()
        {
            Nome nome = new Nome(this.Nome, this.Sobrenome);
            Email email = new Email(this.Email);

            AddNotifications(nome, email);
        }
    }
}