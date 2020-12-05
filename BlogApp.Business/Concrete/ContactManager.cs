using BlogApp.Business.Abstract;
using BlogApp.DataAccess.Abstract;
using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BlogApp.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public void Add(Contact contact)
        {
            _contactRepository.Add(contact);
        }

        public void Delete(Contact contact)
        {
            _contactRepository.Delete(contact);
        }

        public Contact Get(Expression<Func<Contact, bool>> expression)
        {
           return _contactRepository.Get(expression);
        }

        public List<Contact> GetList(Expression<Func<Contact, bool>> expression = null)
        {
            return _contactRepository.GetList(expression);
        }
    }
}
