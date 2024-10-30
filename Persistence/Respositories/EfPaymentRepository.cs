using Application.Features.Payment.DTO;
using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Respositories
{
    public class EfPaymentRepository : EfRepositoryBase<Payment, ECommerceDbContext>, IPaymentRepository
    {
        public EfPaymentRepository(ECommerceDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<PaymentDto>> GetPaymentByOrderIdAsync(int orderId)
        {
            return await _context.Payments
                .Where(payment => payment.OrderId == orderId)
                .Select(payment => new PaymentDto
                {
                    OrderId = payment.OrderId,
                    Amount = payment.Amount,
                    PaymentDate = payment.PaymentDate,
                    PaymentMethod = payment.PaymentMethod.Name
                })
                .ToListAsync();
        }
    }
}
