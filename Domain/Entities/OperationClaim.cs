using Core.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OperationClaim : BaseOperationClaim
    {
        public virtual List<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
