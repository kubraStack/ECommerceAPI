using Application.Abstracts;
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
using System.Text.Json;
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
            private readonly IUserRepository _userRepository;
            private readonly ICustomerRepository _customerRepository;
            private readonly IMapper _mapper;
            private readonly IMailService _mailService;

            public ProductReturnCommandHandler(IOrderRepository orderRepository, IProductRepository productRepository, IHttpContextAccessor httpContextAccessor, IMapper mapper, IOrderDetailRepository orderDetailRepository, IUserRepository userRepository = null, ICustomerRepository customerRepository = null, IMailService mailService = null)
            {
                _orderRepository = orderRepository;
                _productRepository = productRepository;
                _httpContextAccessor = httpContextAccessor;
                _mapper = mapper;
                _orderDetailRepository = orderDetailRepository;
                _userRepository = userRepository;
                _customerRepository = customerRepository;
                _mailService = mailService;
            }

            public async Task<ProductReturnCommandResponse> Handle(ProductReturnCommand request, CancellationToken cancellationToken)
            {
                string emailToNotify = null;
                // Kullanıcı ID'sini alma
                var userId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                var user = await _userRepository.GetByIdAsync(userId);
                if (user == null)
                {
                    throw new Exception("User Bulunamadı");
                }
                var customer = await _customerRepository.GetByUserIdAsync(userId);
                if (customer == null)
                {
                    throw new Exception("Customer Bulunamadı");
                }
                var isGuestUser = customer == null;

                // İade edilecek ürün siparişini alma
                var order = await _orderRepository.GetByIdAsync(request.OrderId);
                if (order == null || order.CustomerId != customer.Id)
                {
                    throw new Exception("Sipariş bulunamadı veya bu sipariş size ait değil.");
                }

               //Sipariş detaylarını alma
               var orderDetails = await _orderDetailRepository.GetByIdAsync(request.OrderId);
                if (order == null || order.CustomerId != customer.Id)
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

                product.StockQuantity += request.Quantity;
                decimal refundAmount = product.Price * request.Quantity;
                order.TotalAmount -= refundAmount;
                order.OrderStatusId = 6;

               
                await _orderRepository.UpdateAsync(order);
                await _productRepository.UpdateAsync(product);

                if (!isGuestUser)
                {
                    emailToNotify = user.Email; // Customer maili
                }
                else
                {
                    // Misafir bilgilerini JSON olarak alıyoruz
                    var guestInfoJson = order.GuestInfo; // Misafir bilgileri JSON olarak buradan alındığını varsayıyoruz

                    using(JsonDocument doc = JsonDocument.Parse(guestInfoJson))
                    {
                        JsonElement root = doc.RootElement;
                        if (root.TryGetProperty("Email", out JsonElement emailElement))
                        {
                            emailToNotify = emailElement.GetString();
                        }
                    }
                    
                }

                // E-posta gönderme işlemi
                if (!string.IsNullOrEmpty(emailToNotify))
                {
                    await _mailService.SendOrderReturnedEmailAsync(emailToNotify, order.Id, new List<string> { product.Name }, request.Reason);
                }


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
