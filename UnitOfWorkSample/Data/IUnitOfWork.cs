using System;

namespace UnitOfWorkSample.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository AuthorRepository { get; }
        IBookRepository BookRepository { get; }
        void Complete();
    }
}
