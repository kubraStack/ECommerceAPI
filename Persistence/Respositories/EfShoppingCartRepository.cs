﻿using Application.Repositories;
using Core.DataAccess;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Respositories
{
    public class EfShoppingCartRepository : EfRepositoryBase<ShoppingCart, ECommerceDbContext>, IShoppingCartRepository
    {
        public EfShoppingCartRepository(ECommerceDbContext context) : base(context)
        {
        }
    }
}
