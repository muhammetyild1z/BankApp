using My.BankApp.Web.Data.Context;
using My.BankApp.Web.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace My.BankApp.Web.Data.Repositories
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class, new()
    {
        private readonly BankContext _context;

        public GenericRepository(BankContext context)
        {
            _context = context;
        }

        public void create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
        public void delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
