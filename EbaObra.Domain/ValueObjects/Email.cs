using Flunt.Notifications;
using Flunt.Validations;

namespace EbaObra.Domain.ValueObjects
{
    public sealed class Email : Notifiable
    {
        private Email()
        {

        }

        public Email(string email)
        {
            this.EnderecoEmail = email;
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(this.EnderecoEmail, "Email.EnderecoEmail", "E-mail é obrigatório")
                .IsEmail(this.EnderecoEmail, "Email.EnderecoEmail", "E-mail inválido.")
            );
        }

        public string EnderecoEmail { get; private set; }
    }
}