using System.Collections.Generic;

namespace UnitOfWorkSample.Data
{
    public interface IRepository<T> where T : class, IDatabaseEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        T Remove(T entity);
    }
}
