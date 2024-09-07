using Application.Features.Customer.Queries.GetById;
using Application.Features.Customer.Queries.GetByIdSelf;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customer.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Domain.Entities.Customer, GetByIdCustomerQueryResponse>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.Orders, opt => opt.MapFrom(src => src.Orders))
                .ForMember(dest => dest.ProductReviews, opt => opt.MapFrom(src => src.ProductReviews))
                .ForMember(dest => dest.ShoppingCart, opt => opt.MapFrom(src => src.ShoppingCart));

            CreateMap<Domain.Entities.Customer, GetByIdCustomerSelfQueryResponse>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.Orders, opt => opt.MapFrom(src => src.Orders))
                .ForMember(dest => dest.ProductReviews, opt => opt.MapFrom(src => src.ProductReviews))
                .ForMember(dest => dest.ShoppingCart, opt => opt.MapFrom(src => src.ShoppingCart));
        }
    }
}
