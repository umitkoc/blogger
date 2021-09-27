using entity;

namespace business.Abstract
{
    public interface IAuthorService
    {
        Author Get();
        void Update(Author author);
    }
}