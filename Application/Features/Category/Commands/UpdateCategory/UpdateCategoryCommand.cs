using Application.Repositories;
using Core.Application.Pipelines.Authorization;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<UpdateCategoryCommandResponse>, ISequredRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] RequiredRoles => ["Admin"];

        public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, UpdateCategoryCommandResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ICategoryRepository _categoryRepository;

            public UpdateCategoryCommandHandler(IHttpContextAccessor httpContextAccessor, ICategoryRepository categoryRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _categoryRepository = categoryRepository;
            }

            public async Task<UpdateCategoryCommandResponse> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
            {
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;
                if (userRole != "Admin")
                {
                    throw new Exception("Kategori silmeye yetkiniz yok.");
                }

                var category = await _categoryRepository.GetByIdAsync(request.Id);
                if (category == null) {
                    throw new Exception("Kategori bulunamadı.");
                }

                category.Name = request.Name;
                category.Description = request.Description;

                await _categoryRepository.UpdateAsync(category);

                return new UpdateCategoryCommandResponse
                {
                    Success = true,
                    Message = "Kategori başarıyla güncellendi"
                };
            }
        }
    }
}
