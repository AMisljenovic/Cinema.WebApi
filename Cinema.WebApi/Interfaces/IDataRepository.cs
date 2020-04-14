using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WebApi.Interfaces
{
    public interface IDataRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(string id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(string id);
    }
}
