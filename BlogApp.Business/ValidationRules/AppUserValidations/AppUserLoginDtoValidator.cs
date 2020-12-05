using BlogApp.Dto.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.ValidationRules.AppUserValidations
{
    public class AppUserLoginDtoValidator:AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(p => p.Email).NotNull().WithMessage("Email alanı boş geçilemez");
            RuleFor(p => p.Password).NotNull().WithMessage("Şifre alanı boş geçilemez");
        }
    }
}
