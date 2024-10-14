using Application.Features.Category.Commands.CreateCategory;
using Application.Features.Category.Commands.UpdateCategory;
using Application.Features.Category.Queries.GetAllCategories;
using Application.Features.Category.Queries.GetByIdCategory;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Category.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCategoryCommand, Domain.Entities.Category>();
            CreateMap<UpdateCategoryCommand, Domain.Entities.Category>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Domain.Entities.Category, GetAllCategoryQueryResponse>();
            CreateMap<Domain.Entities.Category, GetByIdCategoryQueryResponse>();

        }
    }
}
