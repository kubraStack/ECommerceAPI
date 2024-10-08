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

       

    }
}
