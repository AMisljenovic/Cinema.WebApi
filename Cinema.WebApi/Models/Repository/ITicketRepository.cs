using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public interface ITicketRepository<TEntity>
    {
        Task<string> GetByRepertory(string repertoryId);
        Task<IEnumerable<TEntity>> GetByUser(string userId);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(string repertoryId);
    }
}
