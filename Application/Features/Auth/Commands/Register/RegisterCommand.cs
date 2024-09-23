using Application.Abstracts;
using Application.Repositories;
using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entitites;
using Core.Utilities.Hashing;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.Register
{
    public class RegisterCommand :IRequest<RegisterCommandResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }



        public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterCommandResponse>
        {
            private readonly IMapper _mapper;
            private readonly IUserRepository _userRepository;
            private readonly ICustomerRepository _customerRepository;
            private readonly IMailService _mailService;

            public RegisterCommandHandler(IMapper mapper, IUserRepository userRepository, ICustomerRepository customerRepository, IMailService mailService)
            {
                _mapper = mapper;
                _userRepository = userRepository;
                _customerRepository = customerRepository;
                _mailService = mailService;
            }

            public async Task<RegisterCommandResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
            {
                var isUserExist = await _userRepository.GetAsync(u => u.Email == request.Email);
                if (isUserExist != null)
                {
                    throw new BusinessException("Bu e-posta adresi kullanılıyor");
                }
                Domain.Entities.User user = _mapper.Map<Domain.Entities.User>(request);                
                user.UserType = UserType.Customer;

                byte[] passwordHash, passwordSalt;

                HashingHelper.CreatePasswordHash(request.Password, out passwordHash, out passwordSalt);

                user.PasswordSalt = passwordSalt;
                user.PasswordHash = passwordHash;
                


               
                await _userRepository.AddAsync(user);

                var customer = new Domain.Entities.Customer
                {
                    Id = user.Id,
                    BillingAddress = request.BillingAddress,
                    ShippingAddress = request.ShippingAddress,
                };

                await _customerRepository.AddAsync(customer);
                await _mailService.SendEmailAsync(request.Email, "Hoşgeldiniz", "Hesabınız başarıyla oluşturuldu");
                return new RegisterCommandResponse
                {
                    Email = request.Email,
                    Message = "İşlem başarılı"

                };
            }
        }
    }
}
