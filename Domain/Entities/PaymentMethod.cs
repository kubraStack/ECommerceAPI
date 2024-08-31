using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaymentMethod : Entity
    {

        public string Name { get; set; } // Ödeme yöntemi adı
        public string Description { get; set; } // Ödeme yöntemi hakkında açıklama
       
        public ICollection<Payment> Payments { get; set; } 

    }
}
