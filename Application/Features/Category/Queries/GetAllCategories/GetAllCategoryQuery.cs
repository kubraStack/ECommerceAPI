using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.Queries.GetAllCategories
{
    public class GetAllCategoryQuery : IRequest<List<GetAllCategoryQueryResponse>>
    {
        public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, List<GetAllCategoryQueryResponse>>
        {
            private readonly ICategoryRepository _categoryRepository;

            public GetAllCategoryQueryHandler(ICategoryRepository categoryRepository)
            {
                _categoryRepository = categoryRepository;
            }

            public async Task<List<GetAllCategoryQueryResponse>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
            {
                var categories = await _categoryRepository.GetListAsync();
                if (categories == null || !categories.Any())
                {
                    return new List<GetAllCategoryQueryResponse>();
                }
                var response = categories.Select(c => new GetAllCategoryQueryResponse
                {
                    Id = c.Id,
                    Name = c.Name ?? "N/A",
                    Description = c.Description ?? "No Description",
                    CreatedDate = c.CreatedDate
                }).ToList();

                return response;
            }
        }
    }
}
