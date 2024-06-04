using System.Net;

using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
namespace Project.Data
{
    public class MailSendler
    {
        public async Task SendMessage( string toStr, string sub, string text)
        {
            using var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "shevkinvova@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("", toStr));
            emailMessage.Subject = sub;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = text
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 587, false);
                await client.AuthenticateAsync("shevkinvova@yandex.ru", "umkixdvfiexbbqll");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
                
            }
        }
    }
}
