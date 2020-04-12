using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public interface IRepertoryRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> GetByMovie(string movieId);
        Task<TEntity> Get(string movieId, string hallId);
        Task<TEntity> GetById(string id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(string movieId, string hallId);
    }
}
