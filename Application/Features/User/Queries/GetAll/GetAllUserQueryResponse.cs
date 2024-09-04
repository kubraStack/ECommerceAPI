using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Queries.GetAll
{
    public class GetAllUserQueryResponse
    {
        public int TotalCount { get; set; }
        public object Users { get; set; }
    }
}
