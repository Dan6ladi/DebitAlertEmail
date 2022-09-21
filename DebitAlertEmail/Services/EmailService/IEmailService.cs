using DebitAlertEmail.Models;

namespace DebitAlertEmail.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDebit request);
    }
}
