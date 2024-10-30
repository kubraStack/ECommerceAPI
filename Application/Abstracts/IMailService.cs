using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstracts
{
    public interface IMailService
    {
        public Task SendEmailAsync(string toEmail, string subject, string body);    
        public Task SendOrderConfirmationEmailAsync(string toEmail, string orderId);
    }
}
