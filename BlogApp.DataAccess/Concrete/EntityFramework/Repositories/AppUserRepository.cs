using BlogApp.DataAccess.Abstract;
using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Concrete.EntityFramework.Repositories
{
    public class AppUserRepository:GenericRepository<AppUser>,IAppUserRepository
    {
    }
}
