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
    public class EfCustomerRepository : EfRepositoryBase<Customer, ECommerceDbContext>, ICustomerRepository
    {
        private readonly ECommerceDbContext _context;
        public EfCustomerRepository(ECommerceDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Customer?> GetByUserIdAsync(int userId)
        {
            return await _context.Customers
                .FirstOrDefaultAsync(x => x.UserId == userId);
        }
    }
}
