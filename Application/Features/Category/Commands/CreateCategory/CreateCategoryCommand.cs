using Application.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.Commands.CreateCategory
{
    public class CreateCategoryCommand : IRequest<CreateCategoryCommanResponse>, ISequredRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryCommanResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ICategoryRepository _categoryRepository;
            private readonly IMapper _mapper;

            public CreateCategoryCommandHandler(IHttpContextAccessor httpcontextAccessor, ICategoryRepository categoryRepository, IMapper mapper)
            {
                _httpContextAccessor = httpcontextAccessor;
                _categoryRepository = categoryRepository;
                _mapper = mapper;
            }

            public async Task<CreateCategoryCommanResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
            {
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

                if (userRole != "Admin")
                {
                    throw new Exception("Kategori oluşturma yetkiniz yok.");
                }

                var category = _mapper.Map<Domain.Entities.Category>(request);
                category.CreatedDate = DateTime.UtcNow;

                await _categoryRepository.AddAsync(category);
                return new CreateCategoryCommanResponse
                {
                    Success = true,
                    Message = "Category başarıyla eklendi.",
                    CategoryName = category.Name
                };

                
            }
        }
    }
}
