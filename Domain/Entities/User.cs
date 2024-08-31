using Core.DataAccess;
using Core.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseUser
    {
        public string PhoneNumber { get; set; }
        public string Gender{ get; set; }
        public bool IsDeleted { get; set; }
        public Customer Customer { get; set; }
     

    }
}
