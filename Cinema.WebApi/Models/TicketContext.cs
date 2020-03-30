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

            var tickets = new List<Ticket>();

            var random = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < Constants.PlayingMovieIds.Length; i++)
            {
                for (int y = 1; y < 8; y++)
                {
                    tickets.Add(new Ticket
                    {
                        Id = Guid.NewGuid().ToString(),
                        HallId = Constants.HallIds[i].ToString(),
                        MoveId = Constants.PlayingMovieIds[i].ToString(),
                        PlayTime = $"{random.Next(0,8)}:00",
                        Day = y
                    });

                    tickets.Add(new Ticket
                    {
                        Id = Guid.NewGuid().ToString(),
                        HallId = Constants.HallIds[i].ToString(),
                        MoveId = Constants.PlayingMovieIds[i].ToString(),
                        PlayTime = $"{random.Next(9, 15)}:00",
                        Day = y
                    });

                    tickets.Add(new Ticket
                    {
                        Id = Guid.NewGuid().ToString(),
                        HallId = Constants.HallIds[i].ToString(),
                        MoveId = Constants.PlayingMovieIds[i].ToString(),
                        PlayTime = $"{random.Next(16, 23)}:00",
                        Day = y
                    });
                }
            }

            modelBuilder.Entity<Ticket>().HasData(tickets);
        }
    }
}
