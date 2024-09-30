using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.AdminCommands.ChangeProductPriceCommand
{
    public class ChangePriceCommandResponse
    {
        public int ProductId { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public decimal FinalPrice { get; set; }
        public string Message { get; set; }

        public ChangePriceCommandResponse(int productId, decimal oldPrice, decimal newPrice, decimal finalPrice, string message)
        {
            ProductId = productId;
            OldPrice = oldPrice;
            NewPrice = newPrice;
            FinalPrice = finalPrice;
            Message = message;
        }

        public ChangePriceCommandResponse(string message)
        {
            Message = message;
        }
       
        public ChangePriceCommandResponse()
        {
            
        }
    }
}
