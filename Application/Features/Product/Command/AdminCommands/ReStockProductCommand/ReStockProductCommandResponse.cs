using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.AdminCommands.ReStockProductCommand
{
    public class ReStockProductCommandResponse
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Message { get; set; }

        // Tüm bilgileri alan constructor
        public ReStockProductCommandResponse(int productId, string productName, string description, decimal price, int stockQuantity, string imageUrl, int categoryId, string categoryName, string message)
        {
            ProductId = productId;
            ProductName = productName;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            ImageUrl = imageUrl;
            CategoryId = categoryId;
            CategoryName = categoryName;
            Message = message;
        }

        // Sadece mesaj içeren constructor
        public ReStockProductCommandResponse(string message)
        {
            Message = message;
        }

        // Ürün ID'si ve stok miktarı ile mesaj içeren constructor
        public ReStockProductCommandResponse(int productId, int stockQuantity, string message)
        {
            ProductId = productId;
            StockQuantity = stockQuantity;
            Message = message;
        }

    }

}

