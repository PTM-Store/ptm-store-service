using MailKit.Net.Smtp;
using MimeKit;
using ptm_store_service.Data;
using ptm_store_service.Services.Interface;

namespace ptm_store_service.Services
{
    public class EmailService : IEmailService
    {
        public void SendConfirmationEmail(Users user, string token)
        {
            string confirmationLink = $"https://localhost:44344/confirm?token={token}";
            string emailBody = $"Click the following link to confirm your registration: {confirmationLink}";

            SendEmail(user.Email, "Confirmation Email", emailBody);
        }

        public void SendEmail(string toAddress, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("PTM Store", "authienphuoc0000@gmail.com"));
            message.To.Add(new MailboxAddress("", toAddress));
            message.Subject = subject;

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = body;
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, true);
                client.Authenticate("authienphuoc0000@gmail.com", "26Haiduc...");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
