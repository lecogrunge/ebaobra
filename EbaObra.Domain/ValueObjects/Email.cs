namespace EbaObra.Domain.ValueObjects
{
	public sealed class Email
    {
        private Email()
        {

        }

        public Email(string email)
        {
            this.EnderecoEmail = email;
        }

        public string EnderecoEmail { get; private set; }
    }
}