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
    public class EfOrderRepository : EfRepositoryBase<Order, ECommerceDbContext>, IOrderRepository
    {
      

        public EfOrderRepository(ECommerceDbContext context) : base(context)
        {
           
        }

        public async Task<List<Order>> GetAllOrdersWithGuestInfoAsync()
        {
            return await _context.Orders
                 .Include(o => o.OrderDetails)
                 .Select(o => new Order
                 {
                     Id = o.Id,
                     CustomerId = o.CustomerId,
                     GuestInfo = o.GuestInfo,
                     OrderStatusId = o.OrderStatusId,
                     OrderDate = o.OrderDate,
                     TotalAmount = o.TotalAmount,
                     OrderDetails = o.OrderDetails
                 }).ToListAsync();
        }
    }
}
