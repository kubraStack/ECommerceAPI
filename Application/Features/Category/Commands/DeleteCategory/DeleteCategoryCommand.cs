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

namespace Application.Features.Category.Commands.DeleteCategory
{
    public class DeleteCategoryCommand : IRequest<DeleteCategoryCommanResponse>, ISequredRequest
    {
        public int Id { get; set; }
        public DeleteCategoryCommand(int id)
        {
            Id = id;
        }
        public string[] RequiredRoles => ["Admin"];

        public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, DeleteCategoryCommanResponse>
        {
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ICategoryRepository _categoryRepository;

            public DeleteCategoryCommandHandler(IHttpContextAccessor httpContextAccessor, ICategoryRepository categoryRepository)
            {
                _httpContextAccessor = httpContextAccessor;
                _categoryRepository = categoryRepository;
            }

            public async Task<DeleteCategoryCommanResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
            {
                var userRole = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Role)?.Value;

                if (userRole != "Admin")
                {
                    throw new Exception("Kategori silmeye yetkiniz yok.");
                }

                var category = await _categoryRepository.GetByIdAsync(request.Id);
                if (category == null) {
                    throw new Exception("Kategori Bulunamadı");
                }

                await _categoryRepository.DeleteAsync(category);
                return new DeleteCategoryCommanResponse
                {
                    Success = true,
                    Message = "Kategory başarıyla silindi."

                };
            }
        }
    }
}
