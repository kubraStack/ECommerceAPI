using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.Commands.ProductReturn
{
    public class ProductReturnCommandResponse
    {
        private bool v1;
        private string v2;

        public bool Success { get; set; }
        public string Message { get; set; }
        public string Reason { get; set; } // İade nedeni
        public int Quantity { get; set; }
        public decimal RefundAmount { get; set; }

        public ProductReturnCommandResponse(bool success, string message, string reason, int quantity, decimal refundAmount)
        {
            Success = success;
            Message = message;
            Reason = reason;
            Quantity = quantity;
            RefundAmount = refundAmount;
        }
        public ProductReturnCommandResponse()
        {
            
        }

        public ProductReturnCommandResponse(bool v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
