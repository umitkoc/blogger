using System.Collections.Generic;

namespace data.Abstract
{
    public interface IRepo<T>
    {
        T GetById(int id);
        void Delete(T entity);

        void Update(T entity);
        
        ICollection<T> GetAll();

    }
}