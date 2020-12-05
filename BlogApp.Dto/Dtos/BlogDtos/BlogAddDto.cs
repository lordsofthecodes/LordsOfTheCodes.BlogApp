using BlogApp.Dto.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Dto.Dtos.BlogDtos
{
    public class BlogAddDto:IDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public string PicturePath { get; set; }
        public int AppUserId { get; set; }
    }
}
