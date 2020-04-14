using Cinema.WebApi.Configuration;
using Cinema.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cinema.WebApi.Contexts
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var users = new List<User>
            {
                new User
                {
                    Id = Constants.UserIds[0],
                    Name = "Petar",
                    Surname = "Petrovic",
                    Username = "user",
                    Password = "Y2luZW1hdXNlcg==",
                    Role = "User",
                    Birthday = (new DateTime(1994,4,1)).ToShortDateString(),
                    Email = "user@cinemate.com"
                },
                new User
                {
                    Id = Constants.UserIds[1],
                    Name = "Mile",
                    Surname = "Mikic",
                    Username = "user2",
                    Password = "Y2luZW1hdXNlcjI=",
                    Role = "User",
                    Birthday = (new DateTime(1993,11,5)).ToShortDateString(),
                    Email = "user2@cinemate.com"
                },
                new User
                {
                    Id = Constants.UserIds[2],
                    Name = "Aleksa",
                    Surname = "Gavric",
                    Username = "user3",
                    Password = "Y2luZW1hdXNlcjM=",
                    Role = "User",
                    Birthday = (new DateTime(1990,4,6)).ToShortDateString(),
                    Email = "user3@cinemate.com"
                },
                 new User
                {
                    Id = Constants.UserIds[3],
                    Name = "Jovan",
                    Surname = "Lukic",
                    Username = "admin",
                    Password = "Y2luZW1hYWRtaW4=",
                    Role = "Administrator",
                    Birthday = (new DateTime(1994,9,8)).ToShortDateString(),
                    Email = "admin@cinemate.com"
                }
            };
            
            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
