using BlogApp.DataAccess.Abstract;
using BlogApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.DataAccess.Concrete.EntityFramework.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity:class,IEntity,new
    {
        Context context = new Context();

        public void Add(TEntity entity)
        {
            using (context)
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (context)
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (context)
            {
                return context.Set<TEntity>().Where(filter).FirstOrDefault();
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter)
        {
            using (context)
            {
                if (filter==null)
                {
                    return context.Set<TEntity>().ToList();
                }
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (context)
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
