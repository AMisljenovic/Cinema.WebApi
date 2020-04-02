using Cinema.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cinema.WebApi.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var random = new Random((int)DateTime.Now.Ticks);

            var tickets = new List<Ticket>();

            for (int i = 0; i < Constants.PlayingMovieIds.Length; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    //var column = random.Next(0, 4);
                    //var row = random.Next(0, 4);

                    //TODO(AM): For one we should have all seats reserved
                    tickets.AddRange(new List<Ticket>
                    {
                        new Ticket
                        {
                            Id = Guid.NewGuid().ToString(),
                            RepertoryId = Constants.RepertoryIds[i, y, 0],
                            UserId = Constants.UserIds[y % 2],
                            SeatColumn = y % 4,
                            SeatRow = (y + 1) % 4
                        },
                        new Ticket
                        {
                            Id = Guid.NewGuid().ToString(),
                            RepertoryId = Constants.RepertoryIds[i, y, 1],
                            UserId = Constants.UserIds[y % 2],
                            SeatColumn = (y + 2) % 4,
                            SeatRow = (y + 3) % 4
                        },
                        new Ticket
                        {
                            Id = Guid.NewGuid().ToString(),
                            RepertoryId = Constants.RepertoryIds[i, y, 2],
                            UserId = Constants.UserIds[y % 2],
                            SeatColumn = (y + 1) % 4,
                            SeatRow = y % 4
                        }
                    });
                }              
            }
            
            modelBuilder.Entity<Ticket>().HasData(tickets);
        }
    }
}
