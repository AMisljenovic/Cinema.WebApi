using Cinema.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var halls = new List<Hall>
            {
                new Hall
                {
                    Id = Constants.HallIds[0],
                    Name = "A1",
                    Columns = Constants.HallColumns,
                    Rows = Constants.HallRows
                },
                new Hall
                {
                    Id = Constants.HallIds[1],
                    Name = "A2",
                    Columns = Constants.HallColumns,
                    Rows = Constants.HallRows
                },
                new Hall
                {
                    Id = Constants.HallIds[2],
                    Name = "B1",
                    Columns = Constants.HallColumns,
                    Rows = Constants.HallRows
                },
                new Hall
                {
                    Id = Constants.HallIds[3],
                    Name = "B2",
                    Columns = Constants.HallColumns,
                    Rows = Constants.HallRows
                },
                new Hall
                {
                    Id = Constants.HallIds[4],
                    Name = "C",
                    Columns = Constants.HallColumns,
                    Rows = Constants.HallRows
                }
            };

            modelBuilder.Entity<Hall>().HasData(halls);
        }
    }
}
