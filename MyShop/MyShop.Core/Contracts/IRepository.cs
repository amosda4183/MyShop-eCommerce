using System.Linq;
using MyShop.Core.Models;


//Interface built from InMemoryRepository, which declares all repo methods we would want to use.
namespace MyShop.Core.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Collection();
        void Commit();
        void Delete(string Id);
        T Find(string Id);
        void Insert(T t);
        void Update(T t);
    }
}