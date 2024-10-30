using Application.Features.Payment.DTO;
using Core.DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IPaymentRepository : IRepository<Payment>, IAsyncRepository<Payment>
    {
        Task<IEnumerable<PaymentDto>> GetPaymentByOrderIdAsync(int orderId);
    }
}
