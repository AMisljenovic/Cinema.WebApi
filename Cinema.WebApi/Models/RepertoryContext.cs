using Cinema.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cinema.WebApi.Models
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

            var tickets = new List<Repertory>();

            var random = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < Constants.PlayingMovieIds.Length; i++)
            {
                for (int y = 0; y < 7; y++)
                {
                    tickets.Add(new Repertory
                    {
                        Id = Constants.RepertoryIds[i,y].ToString(),
                        HallId = Constants.HallIds[i].ToString(),
                        MoveId = Constants.PlayingMovieIds[i].ToString(),
                        PlayTime = $"{random.Next(0,8)}:00",
                        Day = y + 1
                    });

                    tickets.Add(new Repertory
                    {
                        Id = Guid.NewGuid().ToString(),
                        HallId = Constants.HallIds[i].ToString(),
                        MoveId = Constants.PlayingMovieIds[i].ToString(),
                        PlayTime = $"{random.Next(9, 15)}:30",
                        Day = y + 1
                    });

                    tickets.Add(new Repertory
                    {
                        Id = Guid.NewGuid().ToString(),
                        HallId = Constants.HallIds[i].ToString(),
                        MoveId = Constants.PlayingMovieIds[i].ToString(),
                        PlayTime = $"{random.Next(16, 23)}:45",
                        Day = y + 1
                    });
                }
            }

            modelBuilder.Entity<Repertory>().HasData(tickets);
        }
    }
}
