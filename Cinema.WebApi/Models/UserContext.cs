using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cinema.WebApi.Models
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
                    Id = Guid.NewGuid().ToString(),
                    Username = "user",
                    Password = "Y2luZW1hdXNlcg==",
                    Role = "User",
                    Birthday = (new DateTime(1994,4,1)).ToShortDateString()
                },
                 new User
                {
                    Id = Guid.NewGuid().ToString(),
                    Username = "admin",
                    Password = "Y2luZW1hYWRtaW4=",
                    Role = "Administrator",
                    Birthday = (new DateTime(1994,9,8)).ToShortDateString()
                }
            };
            

            modelBuilder.Entity<User>().HasData(users);
        }
    }
}
