namespace Authentication2FA.Services;

public interface IEmailSender
{
    Task SendEmailAsync(string email, string subject, string message);
}
