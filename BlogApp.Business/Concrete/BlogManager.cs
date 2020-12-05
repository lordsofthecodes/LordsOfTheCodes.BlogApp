using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogManager(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public void Add(Blog blog)
        {
            _blogRepository.Add(blog);
        }

        public void Delete(Blog blog)
        {
            _blogRepository.Delete(blog);
        }

        public Blog Get(Expression<Func<Blog, bool>> expression)
        {
            return _blogRepository.Get(expression);
        }

        public Blog GetById(int id)
        {
            return _blogRepository.Get(p => p.Id == id);
        }

        public List<Blog> GetList(Expression<Func<Blog, bool>> expression = null)
        {
            return _blogRepository.GetList(expression);
        }

        public void Update(Blog blog)
        {
            _blogRepository.Update(blog);
        }
    }
}
