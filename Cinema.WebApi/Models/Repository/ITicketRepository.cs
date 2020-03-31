using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public interface ITicketRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(string movieId, string hallId);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(string movieId, string hallId);
    }
}
