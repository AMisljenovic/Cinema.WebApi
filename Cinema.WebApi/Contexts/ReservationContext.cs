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

            modelBuilder.Entity<Reservation>()
                .HasIndex(p => new { p.RepertoryId, p.SeatColumn, p.SeatRow, p.Date, p.PlayTime }).IsUnique();

            var reservations = new List<Reservation>();

            var random = new Random((int)DateTime.Now.Ticks);
            var date = DateTime.Now;
            var dayOfWeek = date.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)date.DayOfWeek;

            for (int i = 0; i < Constants.PlayingMovieIds.Length; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    var offest = date.DayOfWeek == DayOfWeek.Sunday ? dayOfWeek : dayOfWeek - 1;
                    var daysToAdd = (y + offest) % 7;

                    if (i != 0)
                    {
                        reservations.Add(new Reservation
                        {
                            Id = Guid.NewGuid().ToString(),
                            RepertoryId = Constants.RepertoryIds[i, y, 0],
                            UserId = Constants.UserIds[y % 2],
                            SeatColumn = y % 4,
                            SeatRow = (y + 1) % 4,
                            Date = date.AddDays(daysToAdd).ToShortDateString(),
                            PlayTime = $"{random.Next(0, 8)}:00",
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
                            Date = date.AddDays(daysToAdd).ToShortDateString(),
                            PlayTime = $"{random.Next(9, 15)}:30",
                        },
                        new Reservation
                        {
                            Id = Guid.NewGuid().ToString(),
                            RepertoryId = Constants.RepertoryIds[i, y, 2],
                            UserId = Constants.UserIds[y % 2],
                            SeatColumn = (y + 1) % 4,
                            SeatRow = y % 4,
                            Date = date.AddDays(daysToAdd).ToShortDateString(),
                            PlayTime = $"{random.Next(16, 23)}:45",
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
                        Date = date.ToShortDateString(),
                        PlayTime = $"{random.Next(0, 8)}:00",
                    });
                }
            }
            
            modelBuilder.Entity<Reservation>().HasData(reservations);
        }
    }
}
