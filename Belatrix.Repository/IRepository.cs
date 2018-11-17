using System.Collections.Generic;
namespace Belatrix.Repository
{
    public interface IRepository<T> where T: class
    {
        //CRUD
        int Add(T entity);
        IEnumerable<T> GetList();
        bool Update(T entity);
        bool Delete(T entity);
    }
}
