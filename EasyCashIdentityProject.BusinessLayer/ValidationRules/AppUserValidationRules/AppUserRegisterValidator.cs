using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
    {

        public AppUserRegisterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad sahəsi boş ola bilməz");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyad sahəsi boş ola bilməz");
            RuleFor(x=>x.Username).NotEmpty().WithMessage("İstifadəçi adı boş ola bilməz");
            RuleFor(x=>x.Email).NotEmpty().WithMessage("E-poçt ünvanı sahəsi boş ola bilməz");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Şifrə sahəsi boş ola bilməz");
            RuleFor(x=>x.ConfirmPassword).NotEmpty().WithMessage("Şifrə təkrarı sahəsi boş ola bilməz");
            RuleFor(x=>x.Name).MaximumLength(50).WithMessage("Ən çox 50 xarakter daxil edə bilərsiz");
            RuleFor(x=>x.Name).MinimumLength(3).WithMessage("Ən az 3 xarakter daxil edə bilərsiz");
            RuleFor(x=>x.ConfirmPassword).Equal(y=> y.Password).WithMessage("Şifrələr bərabər deyil");
            RuleFor(x=>x.Email).EmailAddress().WithMessage("Zəhmət olmasa, düzgün e-poçt ünvanı daxil edin");
        }
    }
}
