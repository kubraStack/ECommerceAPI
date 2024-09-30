using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Queries.GetListProduct
{
    public class GetListProductQueryResponse
    {
        public IEnumerable<Domain.Entities.Product> Products { get; set; }
    }
}
