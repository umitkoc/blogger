using System.Collections.Generic;
using System.Linq;
using data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace data.Concrete
{
    public class GenericRepo<TEntity, TContext> : IRepo<TEntity>
    where TEntity : class
    where TContext : DbContext , new()
    {
        TContext _context;
       
        public void Delete(TEntity entity)
        {
           _context.Set<TEntity>().Remove(entity);
           _context.SaveChanges();
        }

        public ICollection<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
           _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
        }
    }
}