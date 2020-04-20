using Cinema.WebApi.Models;
using System.Threading.Tasks;

namespace Cinema.WebApi.Interfaces
{
    public interface IUsersRepository<TEntity>
    {
        Task<User> Get(string email, string username, string password);
        Task<string[]> Add(TEntity entity, string role);
        Task<DbStatusCode> Update(TEntity entity, string oldPassword);
        Task UpdateRole(TEntity entity, string username, string newRole);
        Task Delete(string id);
    }
}
