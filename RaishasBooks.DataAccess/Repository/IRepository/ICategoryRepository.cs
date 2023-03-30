using RaishasBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaishasBooks.DataAccess.Repository.IRepository
{
    interface ICategoryRepository
    {
        void Update(Category category);
    }
}
