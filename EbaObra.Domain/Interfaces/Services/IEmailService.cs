namespace EbaObra.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        void Send(string to, string email, string subject, string body);
    }
}