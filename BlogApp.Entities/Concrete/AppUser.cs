using BlogApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Entities.Concrete
{
    public class AppUser:IEntity
    {
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
