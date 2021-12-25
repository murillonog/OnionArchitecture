using OnionArchitecture.DomainLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.RepositoryLayer.RepositoryPattern
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int Id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Remove(T entity);
        Task SaveChanges();
    }
}
