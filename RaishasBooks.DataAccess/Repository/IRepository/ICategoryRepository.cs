using RaishasBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RaishasBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository
    {
        void Update(Category category);
    }
}
