using LoginApp.Models;

namespace LoginApp.Utils;

public interface IEmailSender
{
    void SendEmail(Mail request);
}