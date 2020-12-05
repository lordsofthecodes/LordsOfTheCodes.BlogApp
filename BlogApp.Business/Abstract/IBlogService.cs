using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetList(Expression<Func<Blog, bool>> expression = null);
        Blog Get(Expression<Func<Blog, bool>> expression);
        Blog GetById(int id);
        void Add(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);
    }
}
