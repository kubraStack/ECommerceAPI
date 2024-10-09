using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderStatus : Entity
    {
        //Sipariş Durum Adı("Pending, Confirmed", vb)
        public string Name { get; set; }

        // Bu duruma ait açıklama veya ek bilgiler
        public string Description { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
