﻿using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogApp.DataAccess.Abstract
{
    public interface IBlogRepository:IGenericRepository<Blog>
    {
    }
}
