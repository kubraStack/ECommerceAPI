using Application.Features.Product.Queries.GetFilteredProduct;
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

        public async Task<List<GetFilteredProductQueryResponse>> GetFilteredProductsAsync(GetFilteredProductQuery query)
        {
            var productQuery = _context.Products.AsQueryable();

            //Category filtered
            if (!string.IsNullOrEmpty(query.Category))
            {
                productQuery = productQuery.Where(p => p.Category.Name == query.Category);
            }
            //Min - Max Price
            if (query.MinPrice.HasValue)
            {
                productQuery = productQuery.Where(p => p.Price >= query.MinPrice.Value);
            }
            else if (query.MaxPrice.HasValue)
            {
                productQuery = productQuery.Where(p => p.Price <= query.MaxPrice.Value);
            }

            //Stock Control
            if (query.InStock.HasValue)
            {
                if (query.InStock.Value)
                {
                    productQuery = productQuery.Where(p => p.StockQuantity > 0); // Stokta olanlar
                }
                else
                {
                    productQuery = productQuery.Where(p => p.StockQuantity == 0); // Stokta olmayanlar
                }
            }

            var result = await productQuery
                .Select(p => new GetFilteredProductQueryResponse
                    {
                       ProductId = p.Id,
                       ProductName = p.Name,
                       Price = p.Price,
                       Category = p.Category.Name,
                       InStock = p.StockQuantity > 0

                    }
                ).ToListAsync();
            return result;
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
           return await _context.Products
                .Where(p =>p.Category.Name == category)
                .ToListAsync();
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
