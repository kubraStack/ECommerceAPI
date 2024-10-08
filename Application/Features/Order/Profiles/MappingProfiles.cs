using Application.Features.Order.DTOS;
using Application.Features.OrderDetails.DTOS;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Domain.Entities.Order, OrderDto>() // Order ile OrderDto arasında eşleme
           .ForMember(dest => dest.OrderDetails, opt => opt.MapFrom(src => src.OrderDetails)); // OrderDetails eşlemesi

            CreateMap<OrderDetail, OrderDetailDto>(); // OrderDetail ile OrderDetailDto arasında eşleme
        }
    }
}
