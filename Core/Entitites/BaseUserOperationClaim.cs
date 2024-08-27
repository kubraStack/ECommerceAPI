using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entitites
{
    public class BaseUserOperationClaim : Entity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
