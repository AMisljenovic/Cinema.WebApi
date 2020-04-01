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
                    var column = random.Next(0, 4);
                    var row = random.Next(0, 4);

                    tickets.Add(
                    new Ticket
                    {
                        Id = Guid.NewGuid().ToString(),
                        RepertoryId = Constants.RepertoryIds[i,y].ToString(),
                        UserId = Constants.UserIds[y % 2].ToString(),
                        SeatColumn = column,
                        SeatRow = row
                    });
                }              
            }
            
            modelBuilder.Entity<Ticket>().HasData(tickets);
        }
    }
}
