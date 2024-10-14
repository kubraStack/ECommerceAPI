using Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.Queries.GetByIdCategory
{
    public class GetByIdCategoryQuery : IRequest<GetByIdCategoryQueryResponse>
    {
        public int Id { get; set; }
        public GetByIdCategoryQuery(int id)
        {
            Id = id;
        }

        public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQuery, GetByIdCategoryQueryResponse>
        {
            private readonly ICategoryRepository _categoryRepository;

            public GetByIdCategoryQueryHandler(ICategoryRepository categoryRepository)
            {
                _categoryRepository = categoryRepository;
            }

            public async Task<GetByIdCategoryQueryResponse> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
            {
               var category = await _categoryRepository.GetByIdAsync(request.Id);
               if (category == null) 
               {
                    return null; 
               }

                return new GetByIdCategoryQueryResponse
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description,

                };
            }
        }
    }
}
