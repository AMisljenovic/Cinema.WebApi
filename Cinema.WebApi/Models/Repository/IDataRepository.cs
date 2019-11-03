using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(string id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(string id);
    }
}
