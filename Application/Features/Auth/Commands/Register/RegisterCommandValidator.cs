using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Auth.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator() {

            RuleFor(i => i.FirstName).NotEmpty().WithMessage("İsim alanı boş olamaz !");
            RuleFor(i => i.LastName).NotEmpty().WithMessage("Soyisim alanı boş olamaz !");
            RuleFor(i => i.Email).NotEmpty().WithMessage("E-posta alanı boş olamaz !");
            RuleFor(i => i.Password).NotEmpty().WithMessage("Şifre alanı boş olamaz");
            RuleFor(i => i.PhoneNumber).NotEmpty().WithMessage("Telefon alanı boş olamaz !");
        }
    }
}
