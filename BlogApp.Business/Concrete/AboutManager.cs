using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using BlogApp.DataAccess.Concrete.EntityFramework.Repositories;
using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutRepository _aboutRepository;
        public AboutManager(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public void Add(About about)
        {
            _aboutRepository.Add(about);
        }

        public About GetById(int id)
        {
            return _aboutRepository.Get(p => p.Id == id);
        }

        public void Update(About about)
        {
            _aboutRepository.Update(about);
        }
    }
}
