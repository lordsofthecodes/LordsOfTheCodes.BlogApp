using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IAboutService
    {
        About GetById(int id);
        void Add(About about);
        void Update(About about);
    }
}
