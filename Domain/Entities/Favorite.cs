using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Favorite : Entity
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }


        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
