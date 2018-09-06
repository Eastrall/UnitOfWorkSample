using Microsoft.EntityFrameworkCore;

namespace UnitOfWorkSample.Data
{
    public interface IAuthorRepository : IRepository<AuthorEntity>
    {
        // Add specific methods related to the Author entity.
    }

    public class AuthorRepository : Repository<AuthorEntity>, IAuthorRepository
    {
        public AuthorRepository(DbContext context) : base(context)
        {
        }
    }
}
