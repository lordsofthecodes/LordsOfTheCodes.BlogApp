using BlogApp.Dto.Dtos.AboutDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.ValidationRules.AboutValidations
{
    public class AboutAddDtoValidator:AbstractValidator<AboutAddDto>
    {
        public AboutAddDtoValidator()
        {
            RuleFor(p => p.PicturePath).NotNull().WithMessage("Resim alanı boş geçilemez");
        }
    }
}
