using BlogApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Entities.Concrete
{
    public class About : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string PicturePath { get; set; }
        public string Text { get; set; }
    }
}
