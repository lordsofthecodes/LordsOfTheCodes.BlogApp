using BlogApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.DataAccess.Abstract
{
    public interface IGenericRepository<TEntity>where TEntity:class,IEntity,new()
    {
        List<TEntity> GetList(Expression<Func<TEntity, bool>> filter);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
