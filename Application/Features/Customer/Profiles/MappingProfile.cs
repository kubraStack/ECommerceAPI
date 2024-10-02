using Application.Features.Customer.Queries.GetByIdSelf;
using Application.Features.Customer.Queries.QueryByAdmin.GetById;
using Application.Features.Order.DTOS;
using Application.Features.OrderDetails.DTOS;
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
            CreateMap<Domain.Entities.Customer, GetByIdCustomerSelfQueryResponse>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FirstName))
                .ForMember(dest => dest.Orders, opt => opt.MapFrom(src =>
                    src.Orders != null
                    ? src.Orders.Select(o => new OrderDto
                    {
                        OrderId = o.Id,
                        OrderDate = o.OrderDate ?? DateTime.Now,
                        TotalAmount = o.TotalAmount,
                        OrderDetails = o.OrderDetail != null
                            ? o.OrderDetail.Select(od => new OrderDetailDto
                            {
                                ProductId = od.ProductId,
                                ProductName = od.Product != null ? od.Product.Name : string.Empty, // Product'ı kontrol et
                                Quantity = od.Quantity,
                                UnitPrice = od.Price
                            }).ToList()
                            : new List<OrderDetailDto>() // Boş bir liste döndür
                    }).ToList()
                    : new List<OrderDto>()) // Boş bir liste döndür
                )
                .ForMember(dest => dest.ProductReviews, opt => opt.MapFrom(src => src.ProductReviews))
                .ForMember(dest => dest.ShoppingCart, opt => opt.MapFrom(src => src.ShoppingCart));

        }
    }
    
}
