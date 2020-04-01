using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public interface IUsersRepository<TEntity>
    {
        Task<User> Get(string username, string password);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task UpdateRole(TEntity entity, string username, string newRole);
        Task Delete(string id);
    }
}
