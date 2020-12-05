using BlogApp.Business.Abstract;
using BlogApp.Business.Concrete;
using BlogApp.DataAccess.Abstract;
using BlogApp.DataAccess.Concrete.EntityFramework.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.Business.IOC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddExtentions(this IServiceCollection services)
        {
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IBlogService, BlogManager>();

            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IBlogRepository, BlogRepository>();



        }
    }
}
