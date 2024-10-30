using Application.Features.OrderDetails.Queries.GetAllOrderDetail;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OrderDetails.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderDetail, GetAllOrderDetailQueryResponse>()
            .ForMember(dest => dest.OrderDetailId, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.OrderId))
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
            .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
            .ForMember(dest => dest.UnitPrice, opt => opt.MapFrom(src => src.Price));
        }
    }
}
