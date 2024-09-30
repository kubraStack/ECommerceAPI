using Application.Features.Product.Command.AdminCommands.AddProductCommand;
using Application.Features.Product.Queries.GetById;
using Application.Features.Product.Queries.GetProductDetails;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<AddProductByAdminCommand, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, GetProductByIdQueryResponse>()
                .ForMember(dest => dest.ProductReviews, opt => opt.MapFrom(src => src.ProductReviews))
                .ReverseMap(); // Eğer ters haritalama gerekiyorsa.

            // ProductReviewResponse için haritalama
            CreateMap<ProductReview, ProductReviewResponse>();

        }
    }
}
