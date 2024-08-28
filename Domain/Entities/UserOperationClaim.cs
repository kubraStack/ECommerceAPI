using Core.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserOperationClaim :BaseUserOperationClaim
    {
        public virtual OperationClaim OperationClaim { get; set; }
        public virtual User User { get; set; }
    }
}
