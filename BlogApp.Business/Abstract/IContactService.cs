using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.Business.Abstract
{
    public interface IContactService
    {
        List<Contact> GetList(Expression<Func<Contact, bool>> expression = null);
        Contact Get(Expression<Func<Contact, bool>> expression);
        void Add(Contact contact);
        void Delete(Contact contact);
    }
}
