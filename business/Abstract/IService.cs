using System.Collections.Generic;

namespace business.Abstract
{
    public interface IService<T>
    {
        T getById(int id);
        ICollection<T> GetAll();
        void Delete(int id);
        void Update(T entity);
    }
}