using EbaObra.Domain.ValueObjects;
using EbaObra.Shared.Commands;
using Flunt.Notifications;
using Flunt.Validations;

namespace EbaObra.Domain.Commands.Usuario
{
    public class AutenticarUsuarioRequest : Notifiable, ICommand
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(this.Senha, 6, "AutenticarUsuarioRequest.Senha", "Senha deve ter no mínimo 6 caracteres."));
        }
    }
}