using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShoppingCart : Entity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ShoppingCartDetail> ShoppingCartDetails { get; set; }
    }
}
