using Application.Features.Product.Queries.GetFilteredProduct;
using Application.Features.Product.Queries.GetTopSellingProduct;
using Core.DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IProductRepository : IRepository<Product>, IAsyncRepository<Product>
    {
        Task<List<GetTopSellingProductQueryResponse>> GetTopSellingProductQueryAsync(int count);
        Task<List<GetFilteredProductQueryResponse>> GetFilteredProductsAsync(GetFilteredProductQuery query);
        Task<List<Product>> GetProductsByCategoryAsync(string category);
    }
}
