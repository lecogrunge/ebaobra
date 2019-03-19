using EbaObra.Domain.Interfaces.Services;
using Flunt.Notifications;

namespace EbaObra.Domain.Services
{
    public class EmailService : Notifiable, IEmailService
    {
        public void Send(string to, string email, string subject, string body)
        {
            throw new System.NotImplementedException();
        }
    }
}
