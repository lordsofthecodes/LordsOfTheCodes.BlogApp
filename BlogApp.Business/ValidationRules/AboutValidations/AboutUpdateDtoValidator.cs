using BlogApp.Dto.Dtos.AboutDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.ValidationRules.AboutValidations
{
    public class AboutUpdateDtoValidator:AbstractValidator<AboutUpdateDto>
    {
        public AboutUpdateDtoValidator()
        {
            RuleFor(p => p.Id).InclusiveBetween(1, int.MaxValue);
        }
    }
}
