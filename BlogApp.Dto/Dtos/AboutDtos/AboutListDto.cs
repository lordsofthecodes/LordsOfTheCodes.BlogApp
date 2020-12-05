using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Dto.Dtos.AboutDtos
{
    public class AboutListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string PicturePath { get; set; }
        public string Text { get; set; }
    }
}
