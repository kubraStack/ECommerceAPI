using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Commands.AddFavoriteProduct
{
    public class AddFavoriteProductCommandResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public AddFavoriteProductCommandResponse(bool success, string message, int productId, string productName)
        {
            Success = success;
            Message = message;
            ProductId = productId;
            ProductName = productName;
        }
        public AddFavoriteProductCommandResponse(bool success, string message)
        {
            Success=success;
            Message = message;
        }
        public AddFavoriteProductCommandResponse()
        {
            
        }
    }
}
