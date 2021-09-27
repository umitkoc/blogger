using System.Collections.Generic;

namespace business.Abstract
{
    public interface IService<T>
    {
        T GetById(int id);
        ICollection<T> GetAll();
        void Delete(T entity);
        void Update(T entity);
    }
}