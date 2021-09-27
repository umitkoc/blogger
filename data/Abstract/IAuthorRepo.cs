using entity;

namespace data.Abstract
{
    public interface IAuthorRepo
    {
        Author Get();
        void Update(Author author);
    }
}