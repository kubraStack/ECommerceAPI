using Application.Features.Product.Queries.GetTopSellingProduct;
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
    public class EfProductRepository : EfRepositoryBase<Product, ECommerceDbContext>, IProductRepository
    {
        public EfProductRepository(ECommerceDbContext context) : base(context)
        {
        }

        public async Task<List<GetTopSellingProductQueryResponse>> GetTopSellingProductQueryAsync(int count)
        {
            // TopSellingProducts için DTO 
            var topSellingProducts = _context.OrderDetails
               .GroupBy(od => od.ProductId)
               .Select(g => new
               {
                   ProductId = g.Key,
                   TotalQuantity = g.Sum(od => od.Quantity)
               })
               .OrderByDescending(g => g.TotalQuantity)
               .Take(count);


            // DTO kullanarak Join yapılacak
            var result = await (from tp in topSellingProducts
                                join p in _context.Products on tp.ProductId equals p.Id
                                select new GetTopSellingProductQueryResponse
                                {
                                    ProductId = tp.ProductId,
                                    Name = p.Name,
                                    Price = p.Price,
                                    TotalSold = tp.TotalQuantity,
                                    ImageUrl = p.ImageUrl
                                }).ToListAsync();

            return result;
        }
    }
}
