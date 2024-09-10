using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Command.AdminCommands.DeleteProductCommand
{
    public class DeleteProductByAdminCommandResponse
    {
        public int ProductId { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
