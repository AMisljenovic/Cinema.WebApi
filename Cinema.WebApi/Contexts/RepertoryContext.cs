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
            var repertoryPrice = 350;

            var random = new Random((int)DateTime.Now.Ticks);
            var date = DateTime.UtcNow;
            for (int i = 0; i < Constants.PlayingMovieIds.Length; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    repertoryPrice = y == 1 ? 200 : 350;

                    repertoires.Add(new Repertory
                    {
                        Id = Constants.RepertoryIds[i,y, 0],
                        HallId = Constants.HallIds[i],
                        MoveId = Constants.PlayingMovieIds[i],
                        PlayTime = $"{random.Next(0,8)}:00",
                        Day = y + 1,
                        Price = repertoryPrice,
                        Date = date.Date.AddDays(y).ToShortDateString()
                    });

                    repertoires.Add(new Repertory
                    {
                        Id = Constants.RepertoryIds[i, y, 1],
                        HallId = Constants.HallIds[i],
                        MoveId = Constants.PlayingMovieIds[i],
                        PlayTime = $"{random.Next(9, 15)}:30",
                        Day = y + 1,
                        Price = repertoryPrice,
                        Date = date.Date.AddDays(y).ToShortDateString()
                    });

                    repertoires.Add(new Repertory
                    {
                        Id = Constants.RepertoryIds[i, y, 2],
                        HallId = Constants.HallIds[i],
                        MoveId = Constants.PlayingMovieIds[i],
                        PlayTime = $"{random.Next(16, 23)}:45",
                        Day = y + 1,
                        Price = repertoryPrice,
                        Date = date.Date.AddDays(y).ToShortDateString()
                    });
                }
            }

            modelBuilder.Entity<Repertory>().HasData(repertoires);
        }
    }
}
