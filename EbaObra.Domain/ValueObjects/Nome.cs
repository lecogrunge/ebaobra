using Flunt.Notifications;
using Flunt.Validations;

namespace EbaObra.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        private Nome()
        {

        }

        public Nome(string primeiroNome, string sobrenome)
        {
            this.PrimeiroNome = primeiroNome;
            this.Sobrenome = sobrenome;

            AddNotifications(new Contract()
                .IsNotNullOrEmpty(this.PrimeiroNome, "Nome.PrimeiroNome", "Nome é obrigatório.")
                .HasMinLen(this.PrimeiroNome, 3, "Nome.PrimeiroNome", "Nome deve conter pelo menos 3 caracteres.")
                
                .IsNotNullOrEmpty(this.Sobrenome, "Nome.Sobrenome", "Sobrenome é obrigatório.")
                .HasMinLen(this.Sobrenome, 3, "Nome.Sobrenome", "Sobrenome deve conter pelo menos 3 caracteres.")
            );
        }

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}