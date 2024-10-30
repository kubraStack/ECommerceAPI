using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShoppingBasket : Entity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ShoppingBasketDetail> ShoppingBasketDetails { get; set; }
    }
}
