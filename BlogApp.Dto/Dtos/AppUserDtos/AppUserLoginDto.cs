using BlogApp.Dto.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Dto.Dtos.AppUserDtos
{
    public class AppUserLoginDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
