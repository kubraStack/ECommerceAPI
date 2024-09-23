using Application.Abstracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.EmailService
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var smtpSettings = _configuration.GetSection("SmtpSettings");
            var smtpClient = new SmtpClient(smtpSettings["Server"])
            {
                Port = int.Parse(smtpSettings["Port"]),
                Credentials = new NetworkCredential(smtpSettings["Username"], smtpSettings["Password"]),
                EnableSsl = true,
                Host = smtpSettings["Host"]
            };

            var mailMsg = new MailMessage
            {
                From = new MailAddress(smtpSettings["SenderEmail"], smtpSettings["SenderName"]),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            mailMsg.To.Add(toEmail);
            try
            {
                await smtpClient.SendMailAsync(mailMsg);
            }
            catch (Exception ex)
            {
                // Hata yönetimi: Loglama veya hata işleme
                Console.WriteLine($"E-posta gönderim hatası: {ex.Message}");
                throw; // Hatanın üst katmana iletilmesi
            }
        }
    }
}
