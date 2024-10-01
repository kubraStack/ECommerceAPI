﻿using Core.DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IFavoriteRepository : IRepository<Favorite>, IAsyncRepository<Favorite>
    {
    }
}
