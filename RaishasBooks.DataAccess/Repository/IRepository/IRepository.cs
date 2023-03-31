using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace RaishasBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id); //Retrieve a category from the database by id 

        //List of Categories baseed on requirements 

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null  //useful for foreign key references 
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null);

        void Add(T entity);  //To add an entity
        void Remove(int id);  //To remove an object or category

        void Remove(T entity); //Another way to remove an object 

        void RemoveRange(IEnumerable<T> entity); // Remnoves a complete range of entities 
    }
}