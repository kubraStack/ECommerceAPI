
using Application.Features.ShoppingBasket.Commands.AddToBasket;
using Application.Features.ShoppingBasket.DTO;
using Core.DataAccess;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IShoppingBasketRepository : IRepository<ShoppingBasket>, IAsyncRepository<ShoppingBasket>
    {
        Task<bool> AddToBasketAsync(int customerId, int productId, int quantity);
        Task<bool> RemoveFromBasketAsync(int customerId, int productId);
        Task<bool> ClearBasketAsync(int customerId);
        Task<bool> UpdateBasketItemQuantityAsync(int customerId, int productId, int quantity);
        Task<ShoppingBasket> GetBasketAsync(int customerId);
        Task<ShoppingBasket> GetBasketWithDetailAsync(int customerId);
        Task<ShoppingBasketDetail> GetBasketItemAsync(int customerId, int productId);
    }
}
