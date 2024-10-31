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

        Task SendOrderCreatedEmailAsync(string toEmail, int orderId, decimal totalAmount);
        Task SendOrderCancelledEmailAsync(string toEmail, int orderId, string reason);
        Task SendOrderReturnedEmailAsync(string toEmail, int orderId, List<string> returnedItems, string returnReason);

    }
}
