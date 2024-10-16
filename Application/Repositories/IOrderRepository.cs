﻿using Core.DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IOrderRepository : IRepository<Order>, IAsyncRepository<Order>
    {
        Task<List<Order>> GetAllOrdersWithGuestInfoAsync();
    }
}
