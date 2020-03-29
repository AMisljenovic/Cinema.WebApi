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

            var firstMovie = new List<Repertory>
            {
                new Repertory
                {
                    Id = Guid.NewGuid().ToString(),
                    MoveId = Constants.PlayingMovieIds[0].ToString(),
                    Time = new DateTime(2020,3,2,7,0,0),
                    AvailableTickets = 30,
                    SoldTickets = 0
                },
                new Repertory
                {
                    Id = Guid.NewGuid().ToString(),
                    MoveId = Constants.PlayingMovieIds[0].ToString(),
                    Time = new DateTime(2020,3,3,12,0,0),
                    AvailableTickets = 30,
                    SoldTickets = 0
                },
                new Repertory
                {
                    Id = Guid.NewGuid().ToString(),
                    MoveId = Constants.PlayingMovieIds[0].ToString(),
                    Time = new DateTime(2020,3,4,15,0,0),
                    AvailableTickets = 30,
                    SoldTickets = 0
                },
                new Repertory
                {
                    Id = Guid.NewGuid().ToString(),
                    MoveId = Constants.PlayingMovieIds[0].ToString(),
                    Time = new DateTime(2020,3,5,17,0,0),
                    AvailableTickets = 30,
                    SoldTickets = 0
                },
                new Repertory
                {
                    Id = Guid.NewGuid().ToString(),
                    MoveId = Constants.PlayingMovieIds[0].ToString(),
                    Time = new DateTime(2020,3,6,19,0,0),
                    AvailableTickets = 30,
                    SoldTickets = 0
                },
                new Repertory
                {
                    Id = Guid.NewGuid().ToString(),
                    MoveId = Constants.PlayingMovieIds[0].ToString(),
                    Time = new DateTime(2020,3,7,21,0,0),
                    AvailableTickets = 30,
                    SoldTickets = 0
                },
                new Repertory
                {
                    Id = Guid.NewGuid().ToString(),
                    MoveId = Constants.PlayingMovieIds[0].ToString(),
                    Time = new DateTime(2020,3,8,23,0,0),
                    AvailableTickets = 30,
                    SoldTickets = 0
                }
            };



            modelBuilder.Entity<Repertory>().HasData(firstMovie);
        }
    }
}
