using System.Net;
using System.Net.Mail;
using Newtonsoft.Json;

namespace WeNeed1.Consumer.EmailHandler.Services;

public class EmailService
{
    public void SendEmail(string message)
    {
        try
        {
            string smtpServer = Environment.GetEnvironmentVariable("SMTP_SERVER") ?? "smtp.gmail.com";
            int smtpPort = int.Parse(Environment.GetEnvironmentVariable("SMTP_PORT") ?? "587");
            string fromMail = Environment.GetEnvironmentVariable("SMTP_USERNAME") ?? "oneed3552@gmail.com";
            string password = Environment.GetEnvironmentVariable("SMTP_PASSWORD") ?? "qvvkbkoaelvflpip";

            var emailData = JsonConvert.DeserializeObject<EmailModelToParse>(message);
            var recipientEmail = emailData.Recipient;
            var subject = emailData.Subject;
            var content = emailData.Content;

            var mailMessageObj = new MailMessage();

            mailMessageObj.From = new MailAddress(fromMail);
            mailMessageObj.Subject = subject;
            mailMessageObj.To.Add(recipientEmail);
            mailMessageObj.Body = content;

            var smtpClient = new SmtpClient()
            {
                Host = smtpServer,
                Port = smtpPort,
                Credentials = new NetworkCredential(fromMail, password),
                EnableSsl = true
            };

            smtpClient.Send(mailMessageObj);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending email: {ex.Message}");
        }
    }
}