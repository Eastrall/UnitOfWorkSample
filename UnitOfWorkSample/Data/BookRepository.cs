using Microsoft.EntityFrameworkCore;

namespace UnitOfWorkSample.Data
{
    public interface IBookRepository : IRepository<BookEntity>
    {
        // Add specific methods related the Book entity.
    }

    public class BookRepository : Repository<BookEntity>, IBookRepository
    {
        public BookRepository(DbContext context) : base(context)
        {
        }
    }
}
