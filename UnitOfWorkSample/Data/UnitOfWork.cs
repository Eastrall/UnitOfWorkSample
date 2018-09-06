using Microsoft.EntityFrameworkCore;

namespace UnitOfWorkSample.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

        public IAuthorRepository AuthorRepository { get; }

        public IBookRepository BookRepository { get; }

        public UnitOfWork(EfContext context)
        {
            this._context = context;
            this.AuthorRepository = new AuthorRepository(context);
            this.BookRepository = new BookRepository(context);
        }
        public void Complete() => _context.SaveChanges();
        
        public void Dispose() => _context.Dispose();
    }
}
