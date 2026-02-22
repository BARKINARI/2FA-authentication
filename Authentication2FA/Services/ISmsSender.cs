namespace Authentication2FA.Services;

public interface ISmsSender
{
    Task SendSmsAsync(string number, string message);
}
