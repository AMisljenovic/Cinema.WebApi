﻿using Cinema.WebApi.Contexts;
using Cinema.WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repositories
{
    public class UserManager : IUsersRepository<User>
    {
        private readonly UserContext _userContext;
        private readonly ReservationContext _reservationContext;

        public UserManager(UserContext userContext, ReservationContext reservationContext)
        {
            _userContext = userContext;
            _reservationContext = reservationContext;
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

        public async Task<string[]> Add(User entity, string role)
        {
            var checkUsername = await _userContext.Users.FirstOrDefaultAsync(user => user.Username == entity.Username);
            var checkEmail = await _userContext.Users.FirstOrDefaultAsync(user => user.Email == entity.Email);

            if (checkEmail != null && checkUsername != null)
            {
                return new string[] { "email", "username" };
            }
            else if (checkEmail != null)
            {
                return new string[] { "email" };
            }
            else if (checkUsername != null)
            {
                return new string[] { "username" };
            }


            entity.Id = Guid.NewGuid().ToString();
            entity.Role = role;
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(entity.Password);
            entity.Password = Convert.ToBase64String(plainTextBytes);

            _userContext.Users.Add(entity);

            await _userContext.SaveChangesAsync();

            return new string[0];
        }

        public async Task<DbStatusCode> Update(User entity, string oldPassword)
        {
            entity.Password = string.IsNullOrEmpty(entity.Password) ? oldPassword : entity.Password; 

            var checkEmail = await _userContext.Users.FirstOrDefaultAsync(user => user.Email == entity.Email);
            if (checkEmail != null)
            {
                return DbStatusCode.EmailInUse;
            }
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(oldPassword);
            var convertedPassword = Convert.ToBase64String(plainTextBytes);

            var newPasswordPlainTextBytes = System.Text.Encoding.UTF8.GetBytes(entity.Password);
            entity.Password = Convert.ToBase64String(newPasswordPlainTextBytes);


            var user = await _userContext.Users.FirstOrDefaultAsync(usr => usr.Password == convertedPassword);
            if (user != null)
            {
                if (!string.IsNullOrEmpty(entity.Email))
                {
                    user.Email = entity.Email;
                }
                
                user.Username = entity.Username;
                user.Name = entity.Name;
                user.Surname = entity.Surname;
                user.Password = entity.Password;

                _userContext.Users.Update(user);
                await _userContext.SaveChangesAsync();

                return DbStatusCode.Executed;
            }

            return DbStatusCode.PasswordDoesntMatch;
        }

        public async Task<DbStatusCode> Delete(User entity)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(entity.Password);
            var convertedPassword = System.Convert.ToBase64String(plainTextBytes);

            var user = await _userContext.Users.FirstOrDefaultAsync(usr => usr.Password == convertedPassword &&
                        (usr.Username == entity.Username || usr.Email == entity.Email));
            if (user != null)
            {
                _userContext.Remove(user);

                var reservations = await _reservationContext.Reservations.Where(res => res.UserId == user.Id).ToListAsync();
                _reservationContext.Reservations.RemoveRange(reservations);

                await _userContext.SaveChangesAsync();
                await _reservationContext.SaveChangesAsync();

                return DbStatusCode.Executed;
            }

            return DbStatusCode.PasswordDoesntMatch;
        }
    }
}
