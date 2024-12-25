using Application.Features.ShoppingBasket.Commands.AddToBasket;
using Application.Features.ShoppingBasket.DTO;
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
    public class EfShoppingBasketRepository : EfRepositoryBase<ShoppingBasket, ECommerceDbContext>, IShoppingBasketRepository
    {
        public EfShoppingBasketRepository(ECommerceDbContext context) : base(context)
        {
        }

       

        public async Task<bool> AddToBasketAsync(int customerId, int productId, int quantity)
        {
          
             var existingBasket = await _context.ShoppingBasket
            .Include(b => b.ShoppingBasketDetails)
            .FirstOrDefaultAsync(b => b.CustomerId == customerId);

            if (existingBasket == null)
            {
                existingBasket = new ShoppingBasket
                {
                    CustomerId = customerId,
                    ShoppingBasketDetails = new List<ShoppingBasketDetail>()
                };
                _context.ShoppingBasket.Add(existingBasket);
                if (!await _context.Products.AnyAsync(p => p.Id == productId))
                {
                    throw new Exception("Geçersiz ürün ID'si.");
                }

            }

            var basketItem = existingBasket.ShoppingBasketDetails
                .FirstOrDefault(d => d.ProductId == productId);

            if (basketItem != null)
            {
                basketItem.Quantity += quantity;
            }
            else
            {
                existingBasket.ShoppingBasketDetails.Add(new ShoppingBasketDetail
                {
                    ProductId = productId,
                    Quantity = quantity
                });
            }
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ClearBasketAsync(int customerId)
        {
            var customerExists = await _context.Customers.AnyAsync(c => c.Id == customerId);
            if (!customerExists)
            {
                throw new Exception("Geçersiz müşteri ID. Sepet temizlenemedi.");
            }

            var shoppingBasket = await _context.ShoppingBasket
                .Include(sb => sb.ShoppingBasketDetails)
                .FirstOrDefaultAsync(sb => sb.CustomerId == customerId);

            if (shoppingBasket == null)
            {
                return false;
            }
            _context.ShoppingBasketDetails.RemoveRange(shoppingBasket.ShoppingBasketDetails);
            
            var changes = await _context.SaveChangesAsync();
            return changes > 0;
        }

        public async Task<ShoppingBasket> GetBasketAsync(int customerId)
        {
           
            var shoppingBasket = await _context.ShoppingBasket
                .Include(b => b.ShoppingBasketDetails)
                .FirstOrDefaultAsync(b => b.CustomerId == customerId);

            
            if (shoppingBasket == null){

                var customerExists = await _context.Customers.AnyAsync(c => c.Id == customerId);
                if (!customerExists)
                {
                    throw new Exception("Geçersiz müşteri ID. Sepet oluşturulamadı.");
                }
                shoppingBasket = new ShoppingBasket
                {
                    CustomerId = customerId,
                    ShoppingBasketDetails = new List<ShoppingBasketDetail>()
                };
                await _context.ShoppingBasket.AddAsync(shoppingBasket);
                await _context.SaveChangesAsync(); 
            }

            return shoppingBasket;
        }

        public async Task<ShoppingBasketDetail> GetBasketItemAsync(int customerId, int productId)
        {
            return await _context.ShoppingBasketDetails
           .Include(d => d.ShoppingBasket)
           .Where(d => d.ShoppingBasket.CustomerId == customerId && d.ProductId == productId)
           .FirstOrDefaultAsync();
        }

        public async Task<ShoppingBasket> GetBasketWithDetailAsync(int customerId)
        {
            var shoppingBasket = await _context.ShoppingBasket
             .Include(b => b.ShoppingBasketDetails)
                 .ThenInclude(d => d.Product)
             .FirstOrDefaultAsync(b => b.CustomerId == customerId);

            if (shoppingBasket == null)
            {
                return null;
            }
            foreach (var item in shoppingBasket.ShoppingBasketDetails)
            {
                item.Price = (double)item.Product.Price;
            } 
            await _context.SaveChangesAsync();
            return shoppingBasket;
        }

        public async Task<bool> RemoveFromBasketAsync(int customerId, int productId)
        {
            var shoppingBasket = await _context.ShoppingBasket
                 .Include(b => b.ShoppingBasketDetails)
                 .FirstOrDefaultAsync(b => b.CustomerId == customerId);
            if (shoppingBasket == null)
            {
                return false;
            }

            
            var basketDetail = shoppingBasket.ShoppingBasketDetails
                .FirstOrDefault(detail => detail.ProductId == productId);

            if (basketDetail == null)
            {
                return false;
            }  
            _context.ShoppingBasketDetails.Remove(basketDetail);
            var changes = await _context.SaveChangesAsync();   
            return changes > 0;
        }

        public async Task<bool> UpdateBasketItemQuantityAsync(int customerId, int productId, int quantity)
        {
           
            var shoppingBasket = await _context.ShoppingBasket
                .Include(sb => sb.ShoppingBasketDetails)
                .FirstOrDefaultAsync(sb => sb.CustomerId == customerId);

            if (shoppingBasket == null)
            {
                return false;
            }
            var basketDetail = shoppingBasket.ShoppingBasketDetails
                .FirstOrDefault(detail => detail.ProductId == productId);

            if (basketDetail == null)
            {
                return false;
            }
            basketDetail.Quantity = quantity;
            var changes = await _context.SaveChangesAsync();

            return changes > 0;
        }

    }
}
