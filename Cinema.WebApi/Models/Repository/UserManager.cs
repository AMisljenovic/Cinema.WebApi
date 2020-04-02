using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public class UserManager : IUsersRepository<User>
    {
        private readonly UserContext _userContext;

        public UserManager(UserContext userContext)
        {
            _userContext = userContext;
        }

        public async Task Add(User entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(entity.Password);
            var convertedPassword = System.Convert.ToBase64String(plainTextBytes);
            entity.Password = convertedPassword;

            _userContext.Users.Add(entity);

            await _userContext.SaveChangesAsync();
        }

        public async Task Delete(string password)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(password);
            var convertedPassword = System.Convert.ToBase64String(plainTextBytes);

            var user = await _userContext.Users.FirstOrDefaultAsync(usr => usr.Password == convertedPassword);
            if (user != null)
            {
                _userContext.Remove(user);
            }

            await _userContext.SaveChangesAsync();
        }

        public async Task<User> Get(string email, string username, string password)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(password);
            var convertedPassword = System.Convert.ToBase64String(plainTextBytes);
            var user = await _userContext.Users
                .FirstOrDefaultAsync(usr => (usr.Username == username || usr.Email == email) && usr.Password == convertedPassword);
            if (user != null)
            {
                user.Password = null;
                return user;
            }

            return null;
        }

        public async Task UpdateRole(User entity, string username, string newRole)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(entity.Password);
            var convertedPassword = System.Convert.ToBase64String(plainTextBytes);

            var user = await _userContext.Users.FirstOrDefaultAsync(usr => usr.Password == convertedPassword);
            if (user != null && user.Role == "Administrator")
            {
                var promotedUser = await _userContext.Users.FirstOrDefaultAsync(usr => usr.Username == username);
                if (promotedUser != null)
                {
                    promotedUser.Role = newRole;

                    _userContext.Users.Update(promotedUser);
                    await _userContext.SaveChangesAsync();

                }
            }
        }

        public async Task Update(User entity)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(entity.Password);
            var convertedPassword = System.Convert.ToBase64String(plainTextBytes);

            var user = await _userContext.Users.FirstOrDefaultAsync(usr => usr.Password == convertedPassword);
            if (user != null)
            {
                user.Birthday = entity.Birthday;
                user.Email = entity.Email;
                user.Username = entity.Username;
                user.Name = entity.Name;
                user.Surname = entity.Surname;

                _userContext.Users.Update(user);
                await _userContext.SaveChangesAsync();           
            }
        }
    }
}
