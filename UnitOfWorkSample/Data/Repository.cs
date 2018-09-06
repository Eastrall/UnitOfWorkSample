using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitOfWorkSample.Data
{
    public class Repository<T> : IRepository<T> where T : class, IDatabaseEntity
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public T Add(T entity) => this._context.Set<T>().Add(entity).Entity;

        public T Get(int id) => this._context.Set<T>().FirstOrDefault(x => x.Id == id);

        public IEnumerable<T> GetAll() => this._context.Set<T>().ToList();

        public T Remove(T entity) => throw new NotImplementedException();
    }
}
