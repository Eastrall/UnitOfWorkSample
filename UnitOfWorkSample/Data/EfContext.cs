using Microsoft.EntityFrameworkCore;

namespace UnitOfWorkSample.Data
{
    public sealed class EfContext : DbContext
    {
        public EfContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AuthorEntity> Authors { get; set; }

        public DbSet<BookEntity> Books { get; set; }
    }
}
