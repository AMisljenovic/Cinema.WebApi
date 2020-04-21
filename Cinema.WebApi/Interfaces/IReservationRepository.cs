using Cinema.WebApi.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WebApi.Interfaces
{
    public interface IReservationRepository<TEntity>
    {
        Task<string> GetByRepertory(string repertoryId);
        Task<string> GetByRepertoryAndUser(string repertoryId, string userId);
        Task<IEnumerable<UserReservationResponse>> GetByUser(string userId);
        Task Add(List<TEntity> entities);
        Task Update(TEntity entity);
        Task Delete(string repertoryId);
        Task DeleteByIds(string[] reservationIds);
    }
}
