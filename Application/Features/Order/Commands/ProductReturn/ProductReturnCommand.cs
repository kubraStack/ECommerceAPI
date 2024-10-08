using Application.Features.Order.DTOS;
using Application.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Order.Commands.ProductReturn
{
    public class ProductReturnCommand : IRequest<ProductReturnCommandResponse>
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Reason { get; set; }
        public int Quantity { get; set; }


        public class ProductReturnCommandHandler : IRequestHandler<ProductReturnCommand, ProductReturnCommandResponse>
        {
            private readonly IOrderRepository _orderRepository;
            private readonly IOrderDetailRepository _orderDetailRepository;
            private readonly IProductRepository _productRepository;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly IMapper _mapper;

            public ProductReturnCommandHandler(IOrderRepository orderRepository, IProductRepository productRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper, IOrderDetailRepository orderDetailRepository)
            {
                _orderRepository = orderRepository;
                _productRepository = productRepository;
                _httpContextAccessor = httpContextAccessor;
                _mapper = mapper;
                _orderDetailRepository = orderDetailRepository;
            }

            public async Task<ProductReturnCommandResponse> Handle(ProductReturnCommand request, CancellationToken cancellationToken)
            {
                // Kullanıcı ID'sini alma
                var customerIdClaim = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
                if (customerIdClaim == null || !int.TryParse(customerIdClaim.Value, out int customerId))
                {
                    throw new Exception("Kullanıcı bilgileri bulunamadı.");
                }

                // İade edilecek ürün siparişini alma
                var order = await _orderRepository.GetByIdAsync(request.OrderId);
                if (order == null || order.CustomerId != customerId)
                {
                    throw new Exception("Sipariş bulunamadı veya bu sipariş size ait değil.");
                }

               //Sipariş detaylarını alma
               var orderDetails = await _orderDetailRepository.GetByIdAsync(request.OrderId);
                if (order == null || order.CustomerId != customerId)
                {
                    throw new Exception("Sipariş bulunamadı veya bu sipariş size ait değil.");
                }

                // Ürün bilgilerini alma
                var product = await _productRepository.GetByIdAsync(request.ProductId);
                if (product == null)
                {
                    throw new Exception("Ürün bulunamadı.");
                }

                // Siparişteki ürün detaylarını bulma
                var orderDetail = await _orderDetailRepository.GetByIdAsync(request.OrderId);
                if (orderDetail == null)
                {
                    throw new Exception("Siparişinizde bu ürün bulunmamaktadır.");
                }

                // İade işlemi için miktar kontrolü
                if (request.Quantity <= 0)
                {
                    throw new Exception("İade edilecek miktar geçersiz.");
                }

                if (request.Quantity > orderDetail.Quantity)
                {
                    throw new Exception("İade edilecek miktar sipariş edilen miktardan fazla olamaz.");
                }

                // Stok güncellemesi
                product.StockQuantity += request.Quantity; // Stok miktarı artar

                // İade tutarını hesaplama
                decimal refundAmount = product.Price * request.Quantity;

                // Siparişin toplam tutarının güncellenmesi
                order.TotalAmount -= refundAmount;

                // Sipariş durumu güncellenmesi (İade durumu)
                order.OrderStatusId = 6;

                // Veritabanı güncellemeleri
                await _orderRepository.UpdateAsync(order);
                await _productRepository.UpdateAsync(product);

                return new ProductReturnCommandResponse
                {
                    Success = true,
                    Message = "Ürün iadesi başarıyla gerçekleştirilmiştir.",
                    RefundAmount = refundAmount
                };
            }

        }

    }
}
