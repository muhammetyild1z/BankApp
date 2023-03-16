using System.Collections.Generic;

namespace My.BankApp.Web.Data.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void create(T entity);
        void update(T entity);
        void delete(T entity);
        List<T> GetAll();
        T GetById(object id);
    }
}
