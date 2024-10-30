using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderDetails.Commands.DeleteOrderDetail
{
    public class DeleteOrderDetailCommandResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public DeleteOrderDetailCommandResponse(bool ısSuccess, string message)
        {
            IsSuccess = ısSuccess;
            Message = message;
        }
    }
}
