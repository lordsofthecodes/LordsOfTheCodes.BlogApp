using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IAppUserService
    {
        List<AppUser> GetList(Expression<Func<AppUser, bool>> expression=null);
        AppUser Get(Expression<Func<AppUser, bool>> expression);
        AppUser GetById(int id);
        void Add(AppUser appUser);
        void Delete(AppUser appUser);
        void Update(AppUser appUser);

    }
}
