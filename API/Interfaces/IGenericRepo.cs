using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Interfaces
{
   public interface IGenericRepository<T> where T : BaseModel
    {
       
        void Create(T item);

        void Update(T item);

        void Delete(T item);

        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> ListAllAsync();
         
        Task<T> GetModelWithSpec(ISpecification<T> spec);

        Task<IEnumerable<T>> ListAsync(ISpecification<T> spec);

        Task<int> CountAsync(ISpecification<T> spec);

        Task<bool> SaveAllAsync();
    }
}