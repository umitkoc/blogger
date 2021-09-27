using System.Collections.Generic;

namespace data.Abstract
{
    public interface IRepo<T>
    {
        T getById(int id);
        void Delete(int id);

        void Update(T entity);
        
        ICollection<T> GetAll();

    }
}