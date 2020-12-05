using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class AppUserManager:IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;
        public AppUserManager(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        public void Add(AppUser appUser)
        {
            _appUserRepository.Add(appUser);
        }

        public void Delete(AppUser appUser)
        {
            _appUserRepository.Delete(appUser);
        }

        public AppUser Get(Expression<Func<AppUser, bool>> expression)
        {
            return _appUserRepository.Get(expression);
        }

        public AppUser GetById(int id)
        {
            return _appUserRepository.Get(p => p.UserId == id);
        }

        public List<AppUser> GetList(Expression<Func<AppUser, bool>> expression = null)
        {
            return _appUserRepository.GetList(expression);
        }

        public void Update(AppUser appUser)
        {
            _appUserRepository.Update(appUser);
        }
    }
}
