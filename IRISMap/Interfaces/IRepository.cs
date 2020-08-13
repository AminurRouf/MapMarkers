using System.Linq;
using IRISMap.Repositories;

namespace IRISMap.Interfaces
{
    public interface IRepository<T> where T: Entity
    {
        IQueryable<T> Entities { get; }
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}