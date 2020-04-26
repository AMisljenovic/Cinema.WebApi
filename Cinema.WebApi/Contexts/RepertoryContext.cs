using Cinema.WebApi.Configuration;
using Cinema.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cinema.WebApi.Contexts
{
    public class RepertoryContext : DbContext
    {
        public RepertoryContext(DbContextOptions<RepertoryContext> options)
            : base(options)
        {
        }

        public DbSet<Repertory> Repertoires { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var repertoires = new List<Repertory>();
            int repertoryPrice;

            var random = new Random((int)DateTime.Now.Ticks);
            var date = DateTime.UtcNow;
            var dayOfWeek = date.DayOfWeek == DayOfWeek.Sunday ? 6 : (int)date.DayOfWeek;

            for (int i = 0; i < Constants.PlayingMovieIds.Length; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    repertoryPrice = y == 1 ? 200 : 350;
                    var daysToAdd = (y + dayOfWeek + 1) % 7;

                    var day = (y + dayOfWeek + 1) % 7;
                    day = day == 0 ? 7 : day;

                    repertoires.Add(new Repertory
                    {
                        Id = Constants.RepertoryIds[i,y, 0],
                        HallId = Constants.HallIds[i],
                        MoveId = Constants.PlayingMovieIds[i],
                        PlayTime = $"{random.Next(0,8)}:00",
                        Day = day,
                        Price = repertoryPrice,
                        Date = date.Date.AddDays(daysToAdd).ToShortDateString()
                    });

                    repertoires.Add(new Repertory
                    {
                        Id = Constants.RepertoryIds[i, y, 1],
                        HallId = Constants.HallIds[i],
                        MoveId = Constants.PlayingMovieIds[i],
                        PlayTime = $"{random.Next(9, 15)}:30",
                        Day = day,
                        Price = repertoryPrice,
                        Date = date.Date.AddDays(daysToAdd).ToShortDateString()
                    });

                    repertoires.Add(new Repertory
                    {
                        Id = Constants.RepertoryIds[i, y, 2],
                        HallId = Constants.HallIds[i],
                        MoveId = Constants.PlayingMovieIds[i],
                        PlayTime = $"{random.Next(16, 23)}:45",
                        Day = day,
                        Price = repertoryPrice,
                        Date = date.Date.AddDays(daysToAdd).ToShortDateString()
                    });
                }
            }

            modelBuilder.Entity<Repertory>().HasData(repertoires);
        }
    }
}
