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

        public async Task SendOrderCancelledEmailAsync(string toEmail, int orderId, string reason)
        {
            string subject = $"Siparişiniz İptal Edildi - Sipariş No: {orderId}";
            string body = $"Merhaba, <br><br>Siparişiniz iptal edilmiştir. <br>Sipariş No: {orderId} <br>İptal Sebebi: {reason} <br><br>Detaylar için bizimle iletişime geçebilirsiniz.";
            await SendEmailAsync(toEmail, subject, body);
        }

        public async Task SendOrderCreatedEmailAsync(string toEmail, int orderId, decimal totalAmount)
        {
            string subject = $"Siparişiniz Oluşturuldu - Sipariş No: {orderId}";
            string body = $"Merhaba, <br><br>Siparişiniz başarıyla oluşturulmuştur. Sipariş No: {orderId} <br>Toplam Tutar: {totalAmount:C} <br><br>Teşekkür ederiz!";
            await SendEmailAsync(toEmail, subject, body);
        }

        public async Task SendOrderReturnedEmailAsync(string toEmail, int orderId, List<string> returnedItems, string returnReason)
        {
            string subject = $"Ürün İadesi - Sipariş No: {orderId}";
            string itemsList = string.Join(", ", returnedItems);
            string body = $"Merhaba, <br><br> Siparişinizdeki  ürünler iade edilmiştir. <br>Sipariş No: {orderId} <br>İade Edilen Ürünler: {itemsList} <br>İade Sebebi: {returnReason} <br><br>Detaylar için bizimle iletişime geçebilirsiniz.";
            await SendEmailAsync(toEmail, subject, body);
        }


    }
}
