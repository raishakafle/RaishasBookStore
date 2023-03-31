using RaishasBooks.DataAccess.Repository.IRepository;
using RaishasBooks.Models;
using RaishasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaishasBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {

            // use .NET LINQ to retrieve the first or default category object, 

            // Then pass the id as a generic entity which matches the cateogry ID.
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);

            if (objFromDb == null)
            // Save changes if not null

            {
                objFromDb.Name = category.Name;
                // _db.SaveChanges();
            }
        }
    }
}
