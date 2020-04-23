using Cinema.WebApi.Configuration;
using Cinema.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cinema.WebApi.Contexts
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options)
            : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var reservations = new List<Reservation>();

            var date = DateTime.UtcNow;
            for (int i = 0; i < Constants.PlayingMovieIds.Length; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (i != 0)
                    {
                        reservations.Add(new Reservation
                        {
                            Id = Guid.NewGuid().ToString(),
                            RepertoryId = Constants.RepertoryIds[i, y, 0],
                            UserId = Constants.UserIds[y % 2],
                            SeatColumn = y % 4,
                            SeatRow = (y + 1) % 4,
                            Date = date.AddDays(i).ToShortDateString()
                        }); ;
                    }
                    
                    reservations.AddRange(new List<Reservation>
                    {                 
                        new Reservation
                        {
                            Id = Guid.NewGuid().ToString(),
                            RepertoryId = Constants.RepertoryIds[i, y, 1],
                            UserId = Constants.UserIds[y % 2],
                            SeatColumn = (y + 2) % 4,
                            SeatRow = (y + 3) % 4,
                            Date = date.AddDays(i).ToShortDateString()
                        },
                        new Reservation
                        {
                            Id = Guid.NewGuid().ToString(),
                            RepertoryId = Constants.RepertoryIds[i, y, 2],
                            UserId = Constants.UserIds[y % 2],
                            SeatColumn = (y + 1) % 4,
                            SeatRow = y % 4,
                            Date = date.AddDays(i).ToShortDateString()
                        }
                    });
                }              
            }

            for (int i = 0; i < Constants.HallRows; i++)
            {
                for (int y = 0; y < Constants.HallColumns; y++)
                {
                    reservations.Add(new Reservation
                    {
                        Id = Guid.NewGuid().ToString(),
                        RepertoryId = Constants.RepertoryIds[0, 0, 0],
                        UserId = Constants.UserIds[1],
                        SeatColumn = y,
                        SeatRow = i,
                        Date = date.ToShortDateString()
                    });
                }
            }
            
            modelBuilder.Entity<Reservation>().HasData(reservations);
        }
    }
}
