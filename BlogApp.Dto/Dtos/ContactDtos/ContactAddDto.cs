using BlogApp.Dto.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Dto.Dtos.ContactDtos
{
    public class ContactAddDto : IDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}
