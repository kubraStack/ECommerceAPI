using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Queries.GetById
{
    public class GetByIdUserQueryResponse
    {
        public Domain.Entities.User User { get; set; }
    }
}
