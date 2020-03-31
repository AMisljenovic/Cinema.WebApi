using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public interface ISeatRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Get(string id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(string id);
    }
}
