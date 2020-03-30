using Cinema.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Cinema.WebApi.Models
{
    public class HallContext : DbContext
    {
        public HallContext(DbContextOptions<HallContext> options)
            : base(options)
        {
        }

        public DbSet<Hall> Halls { get; set; }
        public DbSet<Seat> Seats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var halls = new List<Hall>
            {
                new Hall
                {
                    Id = Constants.HallIds[0].ToString(),
                    Name = "A1",
                    Cloumns = Constants.HallColumns,
                    Rows = Constants.HallRows
                },
                new Hall
                {
                    Id = Constants.HallIds[1].ToString(),
                    Name = "A2",
                    Cloumns = Constants.HallColumns,
                    Rows = Constants.HallRows
                }
            };

            var seats = new List<Seat>(50);

            for (int i = 0; i < Constants.HallIds.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int z = 0; z < 5; z++)
                    {
                        seats.Add(new Seat
                        {
                            Id = Guid.NewGuid().ToString(),
                            HallId = Constants.HallIds[i].ToString(),
                            Rows = j,
                            Cloumns = z,
                            Reserved = false
                        });
                    }
                }
            }

            modelBuilder.Entity<Hall>().HasData(halls);
            modelBuilder.Entity<Seat>().HasData(seats);
        }
    }
}
