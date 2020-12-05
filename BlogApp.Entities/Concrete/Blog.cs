﻿using BlogApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Entities.Concrete
{
    public class Blog:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
        public string PicturePath { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }


    }
}
